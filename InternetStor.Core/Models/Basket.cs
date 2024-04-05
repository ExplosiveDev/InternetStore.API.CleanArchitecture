using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Models
{
	public class Basket
	{
        Basket(Guid id, Guid userId, ICollection<ProductInBasket> products)
        {
			Id = id;
			UserId = userId;
			Products = products;
        }
        public Guid Id { get; }
		public Guid UserId { get; }
		public ICollection<ProductInBasket> Products { get; set; } = [];

		public static Basket Create(Guid id, Guid userId, ICollection<ProductInBasket> products)
		{
			return new Basket(id, userId, products);
		}
	}
}
