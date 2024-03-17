using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using InternetStore.DataAccess;
using Microsoft.EntityFrameworkCore;


namespace IntetnetStore.DataAccess.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ProductStorDBcontext _context;
		public CategoryRepository(ProductStorDBcontext context)
		{
			_context = context;
		}
		public async Task<List<Category>> Get()
		{
			var categorytEntities = await _context.Categories
				.AsNoTracking()
				.ToListAsync();

			var category = categorytEntities
				.Select(c => Category.Create(c.Id, c.Name).Category)
				.ToList();

			return category;
		}
	}
}
