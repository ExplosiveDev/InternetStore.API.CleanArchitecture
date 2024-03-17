using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntetnetStore.DataAccess.Entities;

namespace IntetnetStore.DataAccess.Configuration
{
	public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
	{
		public void Configure(EntityTypeBuilder<CategoryEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(Category.MAX_NAME_LENGHT)
				.IsRequired();

			builder.HasMany(x => x.Products)
				.WithOne(x => x.Category);
		}
	}
}
