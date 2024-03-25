using Microsoft.EntityFrameworkCore;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Seeder;
using IntetnetStore.DataAccess.Entities;
using Microsoft.Extensions.Options;
using IntetnetStore.DataAccess;
using IntetnetStore.DataAccess.Configuration;

namespace InternetStore.DataAccess
{
	public class ProductStoreDBcontext(
		DbContextOptions<ProductStoreDBcontext> options,
		IOptions<AuthorizationOption> authOptions) : DbContext(options)
	{

		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<RoleEntity> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductStoreDBcontext).Assembly);

			modelBuilder.ApplyConfiguration(new RolePermissionConfiguration(authOptions.Value));

			modelBuilder.Entity<CategoryEntity>().HasData(SeedData.GetCategory());
			modelBuilder.Entity<ProductEntity>().HasData(SeedData.GetProduct());
		}
	}
}
