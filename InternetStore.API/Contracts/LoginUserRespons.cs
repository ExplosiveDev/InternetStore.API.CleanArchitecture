using InternetStore.Core.Models;

namespace InternetStore.API.Contracts
{
	public record LoginUserRespons(
	User user,
	string token);
}
