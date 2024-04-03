using AutoMapper;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.DataAccess.Repositories
{
	public class ProductsRepository : IProductsRepository
	{
		private readonly ProductStoreDBcontext _context;
		private readonly IMapper _mapper;
		public ProductsRepository(ProductStoreDBcontext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<List<Product>> Get()
		{
			var productEntities = await _context.Products
				.Include(x => x.Category)
				.Include(x => x.Brand)
				.AsNoTracking()
				.ToListAsync();

			

			return _mapper.Map<List<Product>>(productEntities);
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
				BrandId = product.Brand.Id,
			};
			await _context.Products.AddAsync(producEntity);
			await _context.SaveChangesAsync();

			return producEntity.Id;
		}

		public async Task<Guid> Update(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId, Guid brandId)
		{
			await _context.Products
			   .Where(x => x.Id == id)
				.ExecuteUpdateAsync(s => s
					.SetProperty(p => p.Name, p => name)
					.SetProperty(p => p.Description, p => description)
					.SetProperty(p => p.Price, p => price)
					.SetProperty(p => p.ImagePath, p => imagePath)
					.SetProperty(p => p.Count, p => count)
					.SetProperty(p => p.CategoryId, p => categoryId)
					.SetProperty(p => p.BrandId, p => brandId));

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
