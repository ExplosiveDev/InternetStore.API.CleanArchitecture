using InternetStore.API.Contracts;
using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _categoryRepository;

		public CategoriesController(ICategoryService categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		[HttpGet]
		public async Task<ActionResult<List<CategoryRespons>>> GetCategories()
		{
			var categories = await _categoryRepository.GetAllProducts();

			var response = categories.Select(p => new CategoryRespons(p.Id, p.Name));
			return Ok(response);
		}
	}
}
