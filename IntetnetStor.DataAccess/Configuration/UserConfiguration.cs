﻿using InternetStore.Core.Models;
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

			builder.HasMany(u => u.Roles)
				.WithMany(r => r.Users)
				.UsingEntity<UserRoleEntity>(
					l => l.HasOne<RoleEntity>().WithMany().HasForeignKey(r => r.RoleId),
					r => r.HasOne<UserEntity>().WithMany().HasForeignKey(u => u.UserId));
		}
	}
}
