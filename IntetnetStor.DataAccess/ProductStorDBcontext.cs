using Microsoft.EntityFrameworkCore;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Seeder;
using IntetnetStore.DataAccess.Entities;

namespace InternetStore.DataAccess
{
	public class ProductStorDBcontext : DbContext
	{
        public ProductStorDBcontext(DbContextOptions<ProductStorDBcontext> options)
            :base(options) { }

		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<UserEntity> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CategoryEntity>().HasData(SeedData.GetCategory());
			modelBuilder.Entity<ProductEntity>().HasData(SeedData.GetProduct());
		}
	}
}
