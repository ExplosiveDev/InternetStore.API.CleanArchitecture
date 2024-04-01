using InternetStore.Core.Models;

namespace InternetStore.API.Contracts
{
	public record ProductsResponse(
		Guid Id,
		string Name,
		string Description,
		decimal Price,
		string? ImagePath,
		int Count,
		Category Category,
		Guid CategoryId,
		Brand Brand,
		Guid BrandId);
}
