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
	public class BasketConfiguration : IEntityTypeConfiguration<BasketEntity>
	{
		public void Configure(EntityTypeBuilder<BasketEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasMany(x => x.Products)
				.WithOne(x => x.Basket).HasForeignKey(x => x.BasketId);
		}
	}
}
