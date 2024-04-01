using InternetStore.Core.Models;

namespace InternetStore.Application.Services
{
	public interface IProductsService
	{
		Task<Guid> DeleteProduct(Guid id);
		Task<Guid> CreateProduct(Product product);
		Task<List<Product>> GetAllProducts();
		Task<Product> GetByIdProduct(Guid id);
		Task<Guid> UpdateProduct(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId, Guid brandId);
	}
}