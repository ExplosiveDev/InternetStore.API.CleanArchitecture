using AutoMapper;
using Azure.Core;
using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using InternetStore.Core.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly IProductsService _productsService;
		private readonly IMapper _mapper;

		public ProductsController(IProductsService productsService, IMapper mapper)
		{
			_productsService = productsService;
			_mapper = mapper;
		}

		[HttpGet]
		public async Task<ActionResult<List<ProductsResponse>>> GetProducts()
		{
			var products = await _productsService.GetAllProducts();

			return Ok(_mapper.Map<List<ProductsResponse>>(products));
		}

		[HttpGet("{id:guid}")]
		public async Task<ActionResult<ProductsResponse>> GetProducts(Guid id)
		{
			var product = await _productsService.GetByIdProduct(id);

			return Ok(_mapper.Map<ProductsResponse>(product));
		}

		//[Authorize]
		//[HttpPost]
		//public async Task<ActionResult<Guid>> CreateProducts([FromBody] ProductsRequest request)
		//{
		//	var (product, error) = Product.Create(Guid.NewGuid(), request.Name, request.Description, request.Price, request.ImagePath, request.Count,
		//		Category.Create(request.Category.Id, request.Category.Name).Category, request.CategoryId,
		//		Brand.Create(request.Brand.Id, request.Brand.Name).Brand, request.CategoryId);

		//	if (!string.IsNullOrEmpty(error))
		//	{
		//		return BadRequest(error);
		//	}

		//	var ProductId = await _productsService.CreateProduct(product);

		//	return Ok(ProductId);
		//}

		[Authorize]
		[HttpPut("{id:guid}")]
		public async Task<ActionResult<Guid>> UpdateProducts(Guid id, [FromBody] ProductsRequest request)
		{
			var ProductId = await _productsService.UpdateProduct
				(id, request.Name, request.Description, request.Price, request.ImagePath, request.Count, request.CategoryId,request.BrandId);

			return Ok(ProductId);
		}

		[Authorize]
		[HttpDelete("{id:guid}")]
		public async Task<ActionResult<Guid>> DeleteProducts(Guid id)
		{
			var ProductId = await _productsService.DeleteProduct(id);

			return Ok(ProductId);
		}
	}
}
