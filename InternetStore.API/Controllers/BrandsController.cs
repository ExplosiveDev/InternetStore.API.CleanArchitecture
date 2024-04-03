using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using InternetStore.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BrandsController : ControllerBase
	{
		private readonly IBrandService _brandService;

		public BrandsController(IBrandService brandService)
		{
			_brandService = brandService;
		}

		[HttpGet]
		public async Task<ActionResult<List<CategoryRespons>>> GetBrands()
		{
			var brands = await _brandService.GetAllBrands();

			var response = brands.Select(p => new BrandResponse(p.Id, p.Name));
			return Ok(response);
		}
	}
}
