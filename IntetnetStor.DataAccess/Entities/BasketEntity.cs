using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Entities
{
	public class BasketEntity
	{
        public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public ICollection<ProductInBasketEntity> Products { get; set; } = [];
	}
}
