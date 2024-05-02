using AutoMapper;
using InternetStore.Core.Models;
using InternetStore.DataAccess;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Repositories
{
	public class BasketRepository : IBasketRepository
	{
		private readonly ProductStoreDBcontext _context;
		private readonly IMapper _mapper;
		public BasketRepository(ProductStoreDBcontext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Basket> Get(Guid userId)
		{
			var BasketEntity = _context.Baskets.AsNoTracking().FirstOrDefault(x => x.UserId == userId);
			if (BasketEntity != null)
			{
				var productInBasketEntities = await _context.ProductInBaskets
					.Include(x => x.Product)
					.Include(x => x.Product.Category)
					.Include(x => x.Product.Brand)
					.AsNoTracking()
					.ToListAsync();

				BasketEntity.Products = productInBasketEntities;

				return _mapper.Map<Basket>(BasketEntity);
			}

			await Create(userId);

			BasketEntity = _context.Baskets.AsNoTracking().FirstOrDefault(x => x.UserId == userId);

			if (BasketEntity == null)
			{
				throw new Exception("Failed to create basket."); 
			}

			return await Get(userId);  

		}

		private async Task<BasketEntity> GetWithTracking(Guid userId)
		{
			var BasketEntity = _context.Baskets.FirstOrDefault(x => x.UserId == userId);
			if (BasketEntity != null)
			{
				var productInBasketEntities = await _context.ProductInBaskets
					.Include(x => x.Product)
					.Include(x => x.Product.Category)
					.Include(x => x.Product.Brand)
					.ToListAsync();

				BasketEntity.Products = productInBasketEntities;
			}
			else
			{
				await Create(userId);
				Get(userId);
			}

			return BasketEntity;
		}

		public async Task Create(Guid userId)
		{
			var user = _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == userId);
			if (user != null)
			{
				var newBasket = new BasketEntity()
				{
					Id = Guid.NewGuid(),
					UserId = userId
				};
				_context.Baskets.Add(newBasket);
				await _context.SaveChangesAsync();
			}
		}
		public async Task Update(ProductInBasket product, Guid userId)
		{
			var basketEntity = _context.Baskets.FirstOrDefault(x => x.UserId == userId);
			basketEntity!.Products.Add(_mapper.Map<ProductInBasketEntity>(product));
			await _context.SaveChangesAsync();

		}

		public async Task Delete(Guid productInBasketId, Guid userId) 
		{
			var basketEntity = await GetWithTracking(userId);
			var productInBasket = basketEntity!.Products.FirstOrDefault(x => x.Id == productInBasketId);
			basketEntity.Products.Remove(productInBasket!);
			await _context.SaveChangesAsync();
		}

		public async Task ConfirmBasket(Guid userId, (Guid productId, int count)[] products)
		{
			var basketEntity = await GetWithTracking(userId);
			foreach (var item in products)
			{
				basketEntity.Products.FirstOrDefault(x => x.Id == item.productId).Count = item.count;
			}
			_context.Baskets.Remove(basketEntity); // поки я не створив клас order де це все мало зберіатися)
			await _context.SaveChangesAsync();
		}
	}
}
