namespace InternetStore.API.Contracts
{
	public record LoginUserRequest(
		string Email,
		string Password);
}
