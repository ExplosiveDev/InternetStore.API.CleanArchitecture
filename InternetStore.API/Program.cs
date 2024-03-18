
using InternetStore.API.Extensions;
using InternetStore.Application.Services;
using InternetStore.Core.Abstractions;
using InternetStore.DataAccess;
using InternetStore.DataAccess.Repositories;
using InternetStore.Infrastructure;
using IntetnetStore.DataAccess.Repositories;
using IntetnetStore.DataAccess.Seeder;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));

string connection = builder.Configuration.GetConnectionString("ProductStoreDBcontext") ?? throw new InvalidOperationException("Connection string 'ShopMVCConnection' not found.");

builder.Services.AddDbContext<ProductStorDBcontext>(options => options.UseSqlServer(connection));

builder.Services.AddHttpContextAccessor();

builder.Services.AddApiAuthentication(builder.Configuration);
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));


//Product service
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();

//Category service
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

//User service
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

//Jwt provider
builder.Services.AddScoped<IJwtProvider, JwtProvider>();

//Passwotd hasher
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseAuthentication();

app.UseAuthorization();

app.UseCookiePolicy(new CookiePolicyOptions
{
	MinimumSameSitePolicy = SameSiteMode.Strict,
	HttpOnly = HttpOnlyPolicy.Always,
	Secure = CookieSecurePolicy.Always
});

app.UseCors(x =>
{
	x.WithHeaders().AllowAnyHeader();
	x.WithOrigins("http://localhost:5173");
	x.WithMethods().AllowAnyMethod();
});

app.Run();
