using _360AdsNG.Application.Abstractions;
using _360AdsNG.Application.Services;
using _360AdsNG.Domain.Interfaces;
using _360AdsNG.Domain.Repositories;
using _360AdsNG.Infrastructure.Repositories;
using _360AdsNG.Infrastructure.Seed;
using _360AdsNG.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace _360AdsNG.API.Extensions;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration, ILogger<LoggingCategory> logger)
    {
        logger.LogInformation("Configuring Swagger");
        services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "Fast Api",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Scheme = "Bearer"
            }); 
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
        });

        logger.LogInformation("Configuring Authentication");
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            var key = Encoding.UTF8.GetBytes(configuration.GetSection("JWT:Key").Value);
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = false,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateLifetime = false,
                ValidateAudience = false,
                ValidateIssuer = false,
            };
        });

        logger.LogInformation("Configuring CORS");
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
        });

        logger.LogInformation("Configuring Dependency Injection");
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IRepository, Repository>();
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IBillboardService, BillboardService>();
        services.AddScoped<IVendorService, VendorService>();
        //services.AddScoped<IDbInitializer, DbInitializer>();
    }
}
