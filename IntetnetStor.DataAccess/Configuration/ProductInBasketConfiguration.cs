using InternetStore.Core.Models;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Configuration
{
	public class ProductInBasketConfiguration : IEntityTypeConfiguration<ProductInBasketEntity>
	{
		public void Configure(EntityTypeBuilder<ProductInBasketEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasOne(x => x.Basket)
				.WithMany(x => x.Products)
				.HasForeignKey(x => x.BasketId);
		}
	}
}
