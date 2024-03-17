using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Application.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public async Task<List<Category>> GetAllProducts()
		{
			return await _categoryRepository.Get();
		}
	}
}
