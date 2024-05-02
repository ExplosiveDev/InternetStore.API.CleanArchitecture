using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Models
{
	public class Basket
	{
        Basket(Guid id, Guid userId, ICollection<ProductInBasket> products, double totalPrice)
        {
			Id = id;
			UserId = userId;
			Products = products;
			TotalPrice = totalPrice;
        }
        public Guid Id { get; }
		public Guid UserId { get; }
		public ICollection<ProductInBasket> Products { get; set; } = [];
		public double TotalPrice { get; } = 0;

		public static Basket Create(Guid id, Guid userId, ICollection<ProductInBasket> products, double totalPrice)
		{
			return new Basket(id, userId, products, totalPrice);
		}
	}
}
