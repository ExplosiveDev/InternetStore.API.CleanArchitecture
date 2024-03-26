
using InternetStore.Core.Models;

namespace InternetStore.Application.Services
{
	public interface IUserService
	{
		Task<(User user, string token)> Login(string email, string password);
		Task Register(string userName, string email, string password);
	}
}