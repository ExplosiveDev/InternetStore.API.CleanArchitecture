using InternetStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Entities
{
	public class ProductInBasketEntity
	{
        public Guid Id { get; set; }

		public ProductEntity Product { get; set; }
		public Guid ProductId { get; set; }
		public int Count { get; set; } = 1;

		public BasketEntity Basket { get; set; }
		public Guid BasketId { get; set; }
	}
}
