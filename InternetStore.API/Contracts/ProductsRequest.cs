using InternetStore.Core.Models;

namespace InternetStore.API.Contracts
{
	public record ProductsRequest(
		string Name,
		string Description,
		decimal Price,
		string? ImagePath,
		int Count,
		Category Category,
		Guid CategoryId);
}
