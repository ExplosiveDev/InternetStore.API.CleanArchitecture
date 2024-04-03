using InternetStore.Core.Models;

namespace InternetStore.Application.Services
{
	public interface IBrandService
	{
		Task<List<Brand>> GetAllBrands();
	}
}