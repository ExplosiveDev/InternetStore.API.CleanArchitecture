using InternetStore.Core.Models;

namespace InternetStore.Application.Services
{
	public interface IBasketService
	{
		Task<Guid> AddToBasket(Product product, Guid userId);
		Task<Basket> GetBasket(Guid userId);
		Task<Guid> GetProductInBasketId(Guid userId, Guid productId);
		Task DeleteProdutFromBasker(Guid productInBasketId, Guid userId);
		Task ConfirmBasket(Guid userId, (Guid productId, int count)[] products);
	}
}