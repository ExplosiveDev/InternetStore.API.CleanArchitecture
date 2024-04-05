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
		public async Task AddToBasket(Product product, Guid userId)
		{
			var user = _userRepository.GetById(userId);
			if (user != null)
			{
				var basket = await _basketRepository.Get(userId);
				if (!basket.Products.Any(x => x.ProductId == product.Id))
				{
					ProductInBasketEntity productInBasket = new ProductInBasketEntity()
					{
						Product = _mapper.Map<ProductEntity>(product),
						ProductId = product.Id,
						BasketId = basket.Id,
						Count = 1
					};
					await _basketRepository.Update(_mapper.Map<ProductInBasket>(productInBasket), userId);
				}
			}
		}
		public async Task<Basket> GetBasket(Guid userId)
		{
			return await _basketRepository.Get(userId);
		}
	}
}
