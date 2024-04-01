using InternetStore.Core.Abstractions;
using InternetStore.Core.Models;
using InternetStore.DataAccess.Repositories;
using InternetStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Application.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IPasswordHasher _passwordHasher;
		private readonly IJwtProvider _jwtProvider;

		public UserService(IUserRepository userRepository, IPasswordHasher passwordHasher, IJwtProvider jwtProvider)
		{
			_userRepository = userRepository;
			_passwordHasher = passwordHasher;
			_jwtProvider = jwtProvider;
		}

		public async Task Register(string userName, string email, string password)
		{
			var hashedPassword = _passwordHasher.Generate(password);

			var user = User.Create(Guid.NewGuid(), userName, email, hashedPassword).User;

			await _userRepository.Add(user);
		}

		public async Task<(User user, string token)> Login(string email, string password)
		{
			var user = await _userRepository.GetByEmail(email);

			var result = _passwordHasher.Verify(password, user.PasswordHash);

			if (result == false)
			{
				throw new Exception("Fail to login");
			}

			var token = _jwtProvider.GenerateToken(user);

			return (User.Create(user.Id,user.UserName,user.Email,"password").User, token);
		}
		public async Task<bool> IsUniqueEmail(string email)
		{
			return await _userRepository.IsUniqueEmail(email);
		}
	}
}
