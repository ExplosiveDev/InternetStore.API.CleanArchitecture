using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace InternetStore.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly IUserService _userService;
		private readonly IHttpContextAccessor _context;

		public UsersController(IUserService userService, IHttpContextAccessor context)
		{
			_userService = userService;
			_context = context;
		}

		[HttpPost("register")]
		public async Task<ActionResult> Register([FromBody] RegisterUserRequest request)
		{
			await _userService.Register(request.UserName, request.Email, request.Password);

			return Ok();
		}

		[HttpPost("login")]
		public async Task<ActionResult> Login([FromBody] LoginUserRequest request)
		{
			var token = await _userService.Login(request.Email, request.Password);

			_context.HttpContext.Response.Cookies.Append("tasty-cookies", token);

			return Ok(token);
		}
	}
}
