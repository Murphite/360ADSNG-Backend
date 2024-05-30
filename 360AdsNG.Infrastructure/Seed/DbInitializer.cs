using _360AdsNG.Domain.Constants;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _360AdsNG.Infrastructure.Seed;

public class DbInitializer : IDbInitializer
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly AppDbContext _db;

    public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext db)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _db = db;
    }

    public void Initialize()
    {
        try
        {
            //migrations if they are not applied
            if (_db.Database.GetPendingMigrations().Count() > 0)
            {
                _db.Database.Migrate();
            }
        }
        catch (Exception ex)
        {

        }

        //create roles if they are not created
        if (!_roleManager.RoleExistsAsync(RolesConstant.User).GetAwaiter().GetResult())
        {
            _roleManager.CreateAsync(new IdentityRole(RolesConstant.User)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(RolesConstant.Vendor)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(RolesConstant.Admin)).GetAwaiter().GetResult();

            //if roles are not created then we will create admin user as well 
            _userManager.CreateAsync(new User
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                PhoneNumber = "08130990162",
                FirstName = "Admin",
                LastName = "Admin"
            }, "Admin@123").GetAwaiter().GetResult();

            User user = _db.Users.FirstOrDefault(u => u.Email == "admin@gmail.com");
            _userManager.AddToRoleAsync(user, RolesConstant.Admin).GetAwaiter().GetResult();
        }
        return;
    }


}