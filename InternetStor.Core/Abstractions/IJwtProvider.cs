using InternetStore.Core.Models;

namespace InternetStore.Infrastructure
{
	public interface IJwtProvider
	{
		string GenerateToken(User user);
	}
}