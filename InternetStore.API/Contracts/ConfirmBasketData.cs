namespace InternetStore.API.Contracts
{
	public record ConfirmBasketData(
		Guid productInBasketId,
		int  count);
}
