using InternetStore.Core.Abstractions;
using InternetStore.Core.Enums;
using InternetStore.Core.Models;
using InternetStore.DataAccess;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace IntetnetStore.DataAccess.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly ProductStoreDBcontext _context;
		public UserRepository(ProductStoreDBcontext context)
		{
			_context = context;
		}
		public async Task Add(User user)
		{
			var role = _context.Roles.FirstOrDefault(x => x.Id == (int)Role.User);
			var userEntity = new UserEntity()
			{
				Id = user.Id,
				UserName = user.UserName,
				PasswordHash = user.PasswordHash,
				Email = user.Email,
				Roles = { role },
			};

			await _context.Users.AddAsync(userEntity);
			await _context.SaveChangesAsync();
		}

		public async Task<User> GetByEmail(string email)
		{
			var userEntity = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Email == email) ?? throw new Exception();

			if(userEntity != null)
				return User.Create(userEntity.Id, userEntity.UserName, userEntity.Email, userEntity.PasswordHash).User;
			return null;
		}
		public async Task<User> GetById(Guid userId)
		{
			var userEntity = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Id == userId) ?? throw new Exception();

			if (userEntity != null)
				return User.Create(userEntity.Id, userEntity.UserName, userEntity.Email, userEntity.PasswordHash).User;
			return null;
		}
		public async Task<bool> IsUniqueEmail(string email)
		{
			var user = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Email == email);
			if (user == null) return false;
			else return true;
		}
	}
}
