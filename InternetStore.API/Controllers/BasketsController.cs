using AutoMapper;
using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BasketsController : ControllerBase
	{
		private readonly IBasketService _basketService;
		private readonly IProductsService _productsService;
		private readonly IMapper _mapper;

		public BasketsController(IBasketService basketService, IMapper mapper, IProductsService productsService)
		{
			_basketService = basketService;
			_mapper = mapper;
			_productsService = productsService;
		}

		[HttpGet("{userId:guid}")]
		public async Task<ActionResult<Basket>> GetBasket(Guid userId)
		{
			var basket = await _basketService.GetBasket(userId);

			return Ok(basket);
		}
		[HttpPost("{userId:guid}")]
		public async Task<ActionResult> AddProductToBasket([FromBody] Guid productId, Guid userId)
		{
			var prodEntity = await _productsService.GetByIdProduct(productId);
			var prod = Product.Create(prodEntity.Id, prodEntity.Name, prodEntity.Description, prodEntity.Price, prodEntity.ImagePath, prodEntity.Count, prodEntity.Category, prodEntity.CategoryId, prodEntity.Brand, prodEntity.BrandId).Product;
			await _basketService.AddToBasket(prod, userId);
			return Ok();
		}
	}
}
