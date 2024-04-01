using InternetStore.API.Contracts;
using InternetStore.Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;
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
			var cortage = await _userService.Login(request.Email, request.Password);

			if(string.IsNullOrEmpty(cortage.token)) 
				return BadRequest(new {message = "User name or password is incorrect "});

			if(!_userService.IsUniqueEmail(request.Email).Result)
				return BadRequest(new { message = "this email is already use" });

			LoginUserRespons respons = new LoginUserRespons(cortage.user,cortage.token);
			return Ok(respons);
		}
	}
}
