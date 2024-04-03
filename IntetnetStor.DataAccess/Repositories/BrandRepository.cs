using InternetStore.Core.Models;
using InternetStore.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Repositories
{
	public class BrandRepository : IBrandRepository
	{
		private readonly ProductStoreDBcontext _context;
		public BrandRepository(ProductStoreDBcontext context)
		{
			_context = context;
		}
		public async Task<List<Brand>> Get()
		{
			var brandEntities = await _context.Brands
				.AsNoTracking()
				.ToListAsync();

			var brand = brandEntities
				.Select(c => Brand.Create(c.Id, c.Name).Brand)
				.ToList();

			return brand;
		}
	}
}
