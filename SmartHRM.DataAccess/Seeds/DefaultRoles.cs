using Microsoft.AspNetCore.Identity;
using SmartHRM.Utility.Constants;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            roleManager.CreateAsync(new IdentityRole(SD.RoleSuperAdmin.ToString())).GetAwaiter().GetResult();
            roleManager.CreateAsync(new IdentityRole(SD.RoleAdmin.ToString())).GetAwaiter().GetResult();
            roleManager.CreateAsync(new IdentityRole(SD.RoleBasic.ToString())).GetAwaiter().GetResult();
        }
    }
}