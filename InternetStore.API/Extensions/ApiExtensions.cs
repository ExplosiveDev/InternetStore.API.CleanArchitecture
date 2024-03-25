
using InternetStore.Core.Enums;
using InternetStore.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace InternetStore.API.Extensions
{
	public static class ApiExtensions
	{
		public static void AddApiAuthentication(this IServiceCollection services, IConfiguration configuration)
		{
			var jwtOptions = configuration.GetSection(nameof(JwtOptions)).Get<JwtOptions>();

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
				{
					options.TokenValidationParameters = new TokenValidationParameters()
					{
						ValidateIssuer = false,
						ValidateAudience = false,
						ValidateLifetime = false,
						ValidateIssuerSigningKey = false,
						IssuerSigningKey = new SymmetricSecurityKey(
						Encoding.UTF8.GetBytes(jwtOptions!.SecretKey))
					};

					options.Events = new JwtBearerEvents()
					{
						OnMessageReceived = context =>
						{
							context.Token = context.Request.Cookies["tasty-cookies"];

							return Task.CompletedTask;
						}
					};
				});

		}
	}
}
