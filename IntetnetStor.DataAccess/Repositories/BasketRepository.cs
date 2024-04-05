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
			}
			else
				await Create(userId);

			return _mapper.Map<Basket>(BasketEntity);
		}

		public async Task Create(Guid userId)
		{
			var user = _context.Users.FirstOrDefault(x => x.Id == userId);
			if (user != null)
			{
				var newBasket = new BasketEntity()
				{
					Id = Guid.NewGuid(),
					UserId = userId
				};
				_context.Baskets.Add(newBasket);
				await _context.SaveChangesAsync();
				await Get(userId);
			}
		}
		public async Task Update(ProductInBasket product, Guid userId)
		{
			var basketEntity = _context.Baskets.FirstOrDefault(x => x.UserId == userId);
			basketEntity!.Products.Add(_mapper.Map<ProductInBasketEntity>(product));
			await _context.SaveChangesAsync();

		}
	}
}
