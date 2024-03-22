using Microsoft.EntityFrameworkCore;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Seeder;
using IntetnetStore.DataAccess.Entities;
using Microsoft.Extensions.Options;
using IntetnetStore.DataAccess;
using IntetnetStore.DataAccess.Configuration;

namespace InternetStore.DataAccess
{
	public class ProductStorDBcontext(
		DbContextOptions<ProductStorDBcontext> options,
		IOptions<AuthorizationOptions> authOptions) : DbContext(options)
	{

		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<RoleEntity> Roles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductStorDBcontext).Assembly);

			modelBuilder.ApplyConfiguration(new RolePermissionConfiguration(authOptions.Value));

			modelBuilder.Entity<CategoryEntity>().HasData(SeedData.GetCategory());
			modelBuilder.Entity<ProductEntity>().HasData(SeedData.GetProduct());
		}
	}
}
