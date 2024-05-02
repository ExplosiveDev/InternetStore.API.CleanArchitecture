namespace InternetStore.API.Contracts
{
	public record ProductInBasketRequest(
		Guid id,
		int count);
}
