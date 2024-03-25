using InternetStore.Core.Enums;

namespace InternetStore.Application.Services
{
	public interface IPermissionService
	{
		Task<HashSet<Permission>> GetPermissionsAsync(Guid userId);
	}
}