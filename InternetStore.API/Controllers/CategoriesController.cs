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
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet]
		public async Task<ActionResult<List<CategoryRespons>>> GetCategories()
		{
			var categories = await _categoryService.GetAllCategories();

			var response = categories.Select(p => new CategoryRespons(p.Id, p.Name));
			return Ok(response);
		}
	}
}
