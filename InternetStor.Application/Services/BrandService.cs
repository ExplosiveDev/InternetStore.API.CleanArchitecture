using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using IntetnetStore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Application.Services
{
	public class BrandService : IBrandService
	{
		private readonly IBrandRepository _brandRepository;

		public BrandService(IBrandRepository brandRepository)
		{
			_brandRepository = brandRepository;
		}

		public async Task<List<Brand>> GetAllBrands()
		{
			return await _brandRepository.Get();
		}
	}
}
