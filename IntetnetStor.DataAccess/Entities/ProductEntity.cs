using IntetnetStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.DataAccess.Entities
{
	public class ProductEntity
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string? ImagePath { get; set; }
		public int Count { get; set; }

		public CategoryEntity? Category { get; set; }
		public Guid CategoryId { get; set; }
		public BrandEntity? Brand { get; set; }
		public Guid BrandId { get; set; }

	}
}
