using Azure.Core;
using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using InternetStore.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly IProductsService _productsService;

		public ProductsController(IProductsService productsService)
		{
			_productsService = productsService;
		}

		[HttpGet]
		public async Task<ActionResult<List<ProductsResponse>>> GetProducts()
		{
			var products = await _productsService.GetAllProducts();

			var response = products.Select(p => new ProductsResponse(p.Id, p.Name, p.Description, p.Price, p.ImagePath, p.Count, 
				Category.Create(p.Category.Id, p.Category.Name).Category, p.CategoryId));
			return Ok(response);
		}

		[HttpGet("{id:guid}")]
		public async Task<ActionResult<ProductsResponse>> GetProducts(Guid id)
		{
			var product = await _productsService.GetByIdProduct(id);

			var response = new ProductsResponse(product.Id, product.Name, product.Description, product.Price, product.ImagePath, product.Count, 
				Category.Create(product.Category.Id, product.Category.Name).Category, product.CategoryId);

			return Ok(response);
		}

		[HttpPost]
		public async Task<ActionResult<Guid>> CreateProducts([FromBody] ProductsRequest request)
		{
			var (product, error) = Product.Create(Guid.NewGuid(),request.Name,request.Description,request.Price,request.ImagePath,request.Count, 
				Category.Create(request.Category.Id, request.Category.Name).Category, request.CategoryId);

			if(!string.IsNullOrEmpty(error))
			{
				return BadRequest(error);
			}

			var ProductId = await _productsService.CreateProduct(product);

			return Ok(ProductId);
		}
		[HttpPut("{id:guid}")]
		public async Task<ActionResult<Guid>> UpdateProducts(Guid id, [FromBody] ProductsRequest request)
		{
			var ProductId = await _productsService.UpdateProduct(id, request.Name, request.Description, request.Price, request.ImagePath, request.Count, request.CategoryId);

			return Ok(ProductId);
		}

		[HttpDelete("{id:guid}")]
		public async Task<ActionResult<Guid>> DeleteProducts(Guid id)
		{
			var ProductId = await _productsService.DeleteProduct(id);

			return Ok(ProductId);
		}
	}
}
