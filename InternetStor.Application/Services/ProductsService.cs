

using InternetStore.Core.Models;
using InternetStore.DataAccess.Repositories;

namespace InternetStore.Application.Services
{
	public class ProductsService : IProductsService
	{
		private readonly IProductsRepository _productsRepository;

		public ProductsService(IProductsRepository productsRepository)
		{
			_productsRepository = productsRepository;
		}

		public async Task<List<Product>> GetAllProducts()
		{
			return await _productsRepository.Get();
		}
		public async Task<Guid> CreateProduct(Product product)
		{
			return await _productsRepository.Create(product);
		}
		public async Task<Guid> UpdateProduct(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId)
		{
			return await _productsRepository.Update(id, name, description, price, imagePath, count, categoryId);
		}
		public async Task<Guid> DeleteProduct(Guid id)
		{
			return await _productsRepository.Delete(id);
		}
		public async Task<Product> GetByIdProduct(Guid id)
		{
			return await _productsRepository.GetById(id);
		}
	}
}
