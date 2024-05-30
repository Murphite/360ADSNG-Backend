using Microsoft.AspNetCore.Builder;
using _360AdsNG.Domain.Constants;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace _360AdsNG.Infrastructure.Seed;

public static class Seeder
{
    public static async Task Run(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        string[] roleNames = { RolesConstant.User, RolesConstant.Admin, RolesConstant.Vendor };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        var adminUser = await userManager.FindByEmailAsync("admin@admin.com");
        if (adminUser == null)
        {
            var user = new User
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                PhoneNumber = "08130990162",
                FirstName = "Admin",
                LastName = "Admin"
            };
            var result = await userManager.CreateAsync(user, "Admin@123");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, RolesConstant.Admin);
            }
        }
    }

}
