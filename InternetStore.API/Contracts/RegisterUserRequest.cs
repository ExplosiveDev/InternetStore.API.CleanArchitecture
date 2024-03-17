using InternetStore.Core.Models;

namespace InternetStore.API.Contracts
{

	public record RegisterUserRequest(
	string UserName,
	string Email,
	string Password);

}
