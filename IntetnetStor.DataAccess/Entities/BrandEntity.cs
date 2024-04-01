using InternetStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Entities
{
	public class BrandEntity
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
		public ICollection<ProductEntity> Products { get; set; } = [];
	}
}
