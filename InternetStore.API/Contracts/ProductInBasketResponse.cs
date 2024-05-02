using InternetStore.Core.Models;

namespace InternetStore.API.Contracts
{
	public record ProductInBasketResponse(
		Guid id,
		Product Product,
		int Count
		);
}
