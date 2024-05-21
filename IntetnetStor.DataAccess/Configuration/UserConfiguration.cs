using InternetStore.Core.Models;
using InternetStore.DataAccess.Entities;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntetnetStore.DataAccess.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
	{
		public void Configure(EntityTypeBuilder<UserEntity> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.UserName)
				.HasMaxLength(User.MAX_NAME_LENGHT)
				.IsRequired();

			builder.Property(x => x.Email)
				.IsRequired();

			builder.Property(x => x.PasswordHash)
				.IsRequired();

			//builder.HasMany(u => u.Roles)
			//	.WithMany(r => r.Users)
			//	.UsingEntity<UserRoleEntity>(
			//		l => l.HasOne<RoleEntity>().WithMany().HasForeignKey(r => r.RoleId),
			//		r => r.HasOne<UserEntity>().WithMany().HasForeignKey(u => u.UserId));

			builder.HasMany(u => u.Products).
				WithOne(p => p.Seller).
				HasForeignKey(p => p.SellerId);

			//Seed data
			builder.HasData(
				new UserEntity
				{
					Id = Guid.Parse("6c0136a2-48d9-450f-9814-5cba270dce14"),
					Email = "Vldgromovij@gmail.com",
					PasswordHash = "$2a$11$1m1GjCBPIuOWxIbPWYNMYu8NvAPFkxJLIhr0x26NzVnSA905TAk4a",
					UserName = "VladGromovij"
				},
				new UserEntity
				{
					Id = Guid.Parse("57322de4-860d-4c50-950a-0e88f87d096c"),
					Email = "Saller@gmail.com",
					PasswordHash = "$2a$11$1m1GjCBPIuOWxIbPWYNMYu8NvAPFkxJLIhr0x26NzVnSA905TAk4a",
					UserName = "Saller"
				}
			);
		}
	}
}
