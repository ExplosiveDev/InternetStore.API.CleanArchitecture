using InternetStore.API.Extensions;
using InternetStore.API.Mapper;
using InternetStore.API.Middleware;
using InternetStore.Application.Services;
using InternetStore.Core.Abstractions;
using InternetStore.Infrastructure;
using IntetnetStore.DataAccess;
using IntetnetStore.DataAccess.Mapping;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.CookiePolicy;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, loggerConfig) =>
	loggerConfig.ReadFrom.Configuration(context.Configuration));

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));
builder.Services.Configure<AuthorizationOption>(builder.Configuration.GetSection(nameof(AuthorizationOption)));

builder.Services.AddHttpContextAccessor();

builder.Services.AddApiAuthentication(builder.Configuration);
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));

//Product service
builder.Services.AddScoped<IProductsService, ProductsService>();

//Category service
builder.Services.AddScoped<ICategoryService, CategoryService>();

//Brand service
builder.Services.AddScoped<IBrandService, BrandService>();

//User service
builder.Services.AddScoped<IUserService, UserService>();

//Basket service
builder.Services.AddScoped<IBasketService, BasketService>();

//Jwt provider
builder.Services.AddScoped<IJwtProvider, JwtProvider>();

//Password hasher
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();


//Data Access
builder.Services.AddDataAccess(builder.Configuration);

//Mappers
builder.Services.AddAutoMapper(typeof(DataBaseMapping));
builder.Services.AddAutoMapper(typeof(ContractsMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<RequestLogContextMiddleware>();

app.UseSerilogRequestLogging();

app.MapControllers();

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
