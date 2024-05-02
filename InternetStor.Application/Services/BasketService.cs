using AutoMapper;
using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using InternetStore.DataAccess.Repositories;
using IntetnetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Application.Services
{
	public class BasketService : IBasketService
	{
		private readonly IUserRepository _userRepository;
		private readonly IBasketRepository _basketRepository;
		private readonly IMapper _mapper;

		public BasketService(IUserRepository userRepository, IBasketRepository basketRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_basketRepository = basketRepository;
			_mapper = mapper;
		}
		public async Task<Guid> AddToBasket(Product product, Guid userId)
		{
			var user = _userRepository.GetById(userId);
			if (user != null)
			{
				var basket = await _basketRepository.Get(userId);
				if (!basket.Products.Any(x => x.ProductId == product.Id))
				{
					ProductInBasketEntity productInBasket = new ProductInBasketEntity()
					{
						ProductId = product.Id,
						BasketId = basket.Id,
						Count = 1
					};
					await _basketRepository.Update(_mapper.Map<ProductInBasket>(productInBasket), userId);
					return await GetProductInBasketId(userId,product.Id);
				}
			}
			return Guid.Empty;
		}
		public async Task DeleteProdutFromBasker(Guid productInBasketId, Guid userId)
		{
			var user = _userRepository.GetById(userId);
			if (user != null)
			{
				var basket = await _basketRepository.Get(userId);
				if (basket.Products.Any(x => x.Id == productInBasketId))
				{
					await _basketRepository.Delete(productInBasketId, userId);
				}
			}
		}
		public async Task ConfirmBasket(Guid userId, (Guid productId, int count)[] products)
		{
			var user = _userRepository.GetById(userId);
			if (user != null)
			{
				await _basketRepository.ConfirmBasket(userId, products);
			}
		}
		public async Task<Guid> GetProductInBasketId(Guid userId, Guid productId)
		{
			var basket = await GetBasket(userId);
			return basket.Products.FirstOrDefault(x => x.ProductId == productId)!.Id;
		}
		public async Task<Basket> GetBasket(Guid userId)
		{
			return await _basketRepository.Get(userId);
		}
	}
}
