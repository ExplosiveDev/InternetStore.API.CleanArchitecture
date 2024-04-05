using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Core.Models
{
	public class ProductInBasket
	{
        ProductInBasket(Guid id, Product product, int count, Basket basket, Guid basketId, Guid productId)
        {
            Id = id;
			Product = product;
			Basket = basket;
			BasketId = basketId;
			Count = count;
			ProductId = productId;
        }
        public Guid Id { get; }

		public Product Product { get; }
		public Guid ProductId { get; }
		public int Count { get; }

		public Basket Basket { get; }
		public Guid BasketId { get; }

		public static ProductInBasket Create(
			Guid id, Product product, int count, Basket basket, Guid basketId, Guid productId)
		{
			return new ProductInBasket(id, product, count, basket, basketId, productId);
		}
	}
}
