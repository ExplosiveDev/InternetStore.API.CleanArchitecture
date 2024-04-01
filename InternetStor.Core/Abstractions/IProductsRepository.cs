using InternetStore.Core.Models;

namespace InternetStore.DataAccess.Repositories
{
	public interface IProductsRepository
	{
		Task<Guid> Create(Product product);
		Task<Guid> Delete(Guid id);
		Task<List<Product>> Get();
		Task<Product> GetById(Guid id);
		Task<Guid> Update(Guid id, string name, string description, decimal price, string imagePath, int count, Guid categoryId, Guid brandId);
	}
}