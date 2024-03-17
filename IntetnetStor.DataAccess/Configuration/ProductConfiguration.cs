using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using InternetStore.DataAccess.Entities;
using InternetStore.Core.Models;

namespace InternetStore.DataAccess.Configuration
{
	public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
	{
		public void Configure(EntityTypeBuilder<ProductEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(Product.MAX_NAME_LENGHT)
				.IsRequired();

			builder.Property(x => x.Description)
				.HasMaxLength(Product.MAX_DESCRIPTION_LENGHT)
				.IsRequired();

			builder.Property(x => x.Price)
				.IsRequired();

			builder.Property(x => x.Count)
				.IsRequired();

			builder.Property(x => x.CategoryId) 
				.IsRequired();

			builder.HasOne(x => x.Category)
				.WithMany(x => x.Products)
				.HasForeignKey(x => x.CategoryId);
		}
	}
}
