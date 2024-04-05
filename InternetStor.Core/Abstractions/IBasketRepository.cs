using InternetStore.Core.Models;

namespace IntetnetStore.DataAccess.Repositories
{
	public interface IBasketRepository
	{
		Task<Basket> Get(Guid userId);
		Task Create(Guid userId);
		Task Update(ProductInBasket product, Guid userId);
	}
}