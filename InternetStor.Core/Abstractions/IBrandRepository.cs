using InternetStore.Core.Models;

namespace IntetnetStore.DataAccess.Repositories
{
	public interface IBrandRepository
	{
		Task<List<Brand>> Get();
	}
}