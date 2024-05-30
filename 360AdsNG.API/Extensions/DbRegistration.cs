using _360AdsNG.Domain.Entities;
using _360AdsNG.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _360AdsNG.API.Extensions;
   

public static class DbRegistration
{
    public static void AddDbServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
            optionsBuilder =>
            {
                optionsBuilder.MigrationsAssembly(typeof(AppDbContext).Assembly.GetName().Name);
                // optionsBuilder.UseNetTopologySuite();
            }));
       // b => b.MigrationsAssembly("360AdsNG.Infrastructure")));

        services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
    }
}

