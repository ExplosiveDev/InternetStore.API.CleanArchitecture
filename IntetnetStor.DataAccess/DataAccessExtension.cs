using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using InternetStore.DataAccess;
using InternetStore.DataAccess.Repositories;
using IntetnetStore.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess
{
	public static class DataAccessExtension
	{
		public static IServiceCollection AddDataAccess(
		this IServiceCollection services,
		IConfiguration configuration)
		{
			services.AddDbContext<ProductStoreDBcontext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString(nameof(ProductStoreDBcontext)));
			});

			services.AddScoped<IProductsRepository, ProductsRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IBrandRepository, BrandRepository>();

			return services;
		}
	}
}
