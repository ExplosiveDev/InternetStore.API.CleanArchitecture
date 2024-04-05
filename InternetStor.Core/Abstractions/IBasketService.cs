using InternetStore.Core.Models;

namespace InternetStore.Application.Services
{
	public interface IBasketService
	{
		Task AddToBasket(Product product, Guid userId);
		Task<Basket> GetBasket(Guid userId);
	}
}