using InternetStore.API.Contracts;
using InternetStore.API.Extensions;
using InternetStore.Application.Services;
using InternetStore.Core.Enums;
using InternetStore.Core.Models;
using InternetStore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Endpoints
{
	public static class ProductEndpoint
	{
		public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder app)
		{
			var endpoints = app.MapGroup("products");


			endpoints.MapGet(string.Empty, GetProducts)
				.RequirePermissions(Permission.Read);

			return endpoints;
		}

		private static async Task<IResult> GetProducts(ProductsService productsService)
		{
			var products = await productsService.GetAllProducts();

			var response = products.Select(p => new ProductsResponse(p.Id, p.Name, p.Description, p.Price, p.ImagePath, p.Count,
				Category.Create(p.Category.Id, p.Category.Name).Category, p.CategoryId));

			return Results.Ok(response);
		}

	}
}
