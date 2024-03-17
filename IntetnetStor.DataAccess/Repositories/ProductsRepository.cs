using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.DataAccess.Repositories
{
	public class ProductsRepository : IProductsRepository
	{
		private readonly ProductStorDBcontext _context;
		public ProductsRepository(ProductStorDBcontext context)
		{
			_context = context;
		}

		public async Task<List<Product>> Get()
		{
			var productEntities = await _context.Products
				.Include(x => x.Category)
				.AsNoTracking()
				.ToListAsync();

			var products = productEntities
				.Select(p => Product.Create(p.Id, p.Name, p.Description, p.Price, p.ImagePath, p.Count, 
					Category.Create(p.Category.Id, p.Category.Name).Category, p.Category.Id).Product)
				.ToList();

			return products;
		}

		public async Task<Guid> Create(Product product)
		{
			var producEntity = new ProductEntity
			{
				Id = product.Id,
				Name = product.Name,
				Description = product.Description,
				ImagePath = product.ImagePath,
				Count = product.Count,
				Price = product.Price,
				CategoryId = product.Category.Id,
			};
			await _context.Products.AddAsync(producEntity);
			await _context.SaveChangesAsync();

			return producEntity.Id;
		}

		public async Task<Guid> Update(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId)
		{
			await _context.Products
			   .Where(x => x.Id == id)
				.ExecuteUpdateAsync(s => s
					.SetProperty(p => p.Name, p => name)
					.SetProperty(p => p.Description, p => description)
					.SetProperty(p => p.Price, p => price)
					.SetProperty(p => p.ImagePath, p => imagePath)
					.SetProperty(p => p.Count, p => count)
					.SetProperty(p => p.CategoryId, p => categoryId));

			return id;
		}

		public async Task<Guid> Delete(Guid id)
		{
			await _context.Products
			   .Where(x => x.Id == id)
			   .ExecuteDeleteAsync();

			return id;
		}

		public async Task<Product> GetById(Guid id)
		{
			var products = await Get();
			return products.FirstOrDefault(x => x.Id == id);
		}
	}
}
