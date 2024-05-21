using AutoMapper;
using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InternetStore.API.Controllers
{
	[Authorize]
	[ApiController]
	[Route("[controller]")]

	public class BasketsController : ControllerBase
	{
		private readonly IBasketService _basketService;
		private readonly IProductsService _productsService;
		private readonly IUserService _usersService;
		private readonly IMapper _mapper;

		public BasketsController(IBasketService basketService, IMapper mapper, IProductsService productsService, IUserService usersService)
		{
			_basketService = basketService;
			_mapper = mapper;
			_productsService = productsService;
			_usersService = usersService;
		}

		[HttpGet("{userId:guid}")]
		public async Task<ActionResult<Basket>> GetBasket(Guid userId)
		{
			var basket = await _basketService.GetBasket(userId);

			return Ok(basket);
		}

		[HttpPost("AddProduct/{userId:guid}")]
		public async Task<ActionResult<ProductInBasketResponse>> AddProductToBasket([FromBody] AddProductInBasketRequest request, Guid userId)
		{
			var prodEntity = await _productsService.GetByIdProduct(request.id);
			if (prodEntity == null)
			{
				return NotFound(new { message = "Product not found" });
			}

			try
			{
				var seller = await _usersService.GetById(userId);
				var prod = Product.Create(prodEntity.Id, prodEntity.Name, prodEntity.Description, prodEntity.Price, prodEntity.ImagePath, prodEntity.Count, prodEntity.Category, prodEntity.CategoryId, prodEntity.Brand, prodEntity.BrandId, seller, seller.Id).Product;
				var id = await _basketService.AddToBasket(prod, userId);
				return Ok(new ProductInBasketResponse(id, prod, 1));
			}
			catch (Exception ex)
			{
				return StatusCode(500, new { message = "An error occurred while adding product to cart", error = ex.Message });
			}
		}

		[HttpDelete("Delete/{userId:guid}")]
		public async Task<ActionResult> DeleteProductFromBasket([FromBody] DeleteProductFromBasket request, Guid userId)
		{
			await _basketService.DeleteProdutFromBasker(request.productInBasketId, userId);
			return Ok();

		}
		[HttpPost("ConfirmBasket/{userId:guid}")]
		public async Task<ActionResult> ConfirmBasket([FromBody] ConfirmBasketRequest request, Guid userId)
		{
			var products = new (Guid, int)[request.data.Length];
			int index = 0;
			foreach (var data in request.data)
			{
				products[index] = (data.productInBasketId, data.count);
				index++;
			}
			await _basketService.ConfirmBasket(userId, products);
			return Ok();
		}
		//BadRequest();
		//[HttpPut("{userId:guid}")]
		//public async Task<ActionResult> UpdateProductInBasket([FromBody] UpdateProductInBasketRequest request, Guid userId)
		//{
		//	var b = request;
		//	return Ok();
		//}
	}
}
