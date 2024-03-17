using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using InternetStore.DataAccess;
using IntetnetStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace IntetnetStore.DataAccess.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly ProductStorDBcontext _context;
		public UserRepository(ProductStorDBcontext context)
		{
			_context = context;
		}
		public async Task Add(User user)
		{
			var userEntity = new UserEntity()
			{
				Id = user.Id,
				UserName = user.UserName,
				PasswordHash = user.PasswordHash,
				Email = user.Email,
			};

			await _context.Users.AddAsync(userEntity);
			await _context.SaveChangesAsync();
		}

		public async Task<User> GetByEmail(string email)
		{
			var userEntity = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Email == email) ?? throw new Exception();

			return User.Create(userEntity.Id, userEntity.UserName, userEntity.PasswordHash, userEntity.Email).User;
		}
	}
}
