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
	public class BrandConfiguration : IEntityTypeConfiguration<BrandEntity>
	{
		public void Configure(EntityTypeBuilder<BrandEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(Brand.MAX_NAME_LENGHT)
				.IsRequired();

			builder.HasMany(x => x.Products)
				.WithOne(x => x.Brand);
		}
	}
}
