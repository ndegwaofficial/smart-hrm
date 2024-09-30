using Microsoft.AspNetCore.Identity;
using SmartHRM.Models;
using SmartHRM.Utility.Constants;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Seeds
{
    public static class DefaultUsers
    {
        public static async Task SeedBasicUserAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            userManager.CreateAsync(new ApplicationUser
            {
                UserName = "basic@felsoftsystems.com",
                Email = "basic@felsoftsystems.com",
                FirstName = "Kenan",
                LastName = "Odhiambo",
                PhoneNumber = "0721388689",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,

            }, "Admin123*@P").GetAwaiter().GetResult();

                var user = await userManager.FindByEmailAsync("basic@felsoftsystems.com");

           
                if (user == null)
                {                     
                     userManager.AddToRoleAsync(user, SD.RoleBasic.ToString()).GetAwaiter().GetResult();
                }
          
        }

        public static async Task SeedSuperAdminAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@felsoftsystems.com",
                Email = "admin@felsoftsystems.com",
                FirstName = "Felix",
                LastName = "Aduol",
                PhoneNumber = "0721388689",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,

            }, "Admin123*@P").GetAwaiter().GetResult();
           
           
            var user = await userManager.FindByEmailAsync("admin@felsoftsystems.com");
            if (user == null)
            {
                    userManager.AddToRoleAsync(user, SD.RoleSuperAdmin).GetAwaiter().GetResult();
                    userManager.AddToRoleAsync(user, SD.RoleAdmin).GetAwaiter().GetResult();
                    userManager.AddToRoleAsync(user, SD.RoleBasic).GetAwaiter().GetResult();
            }    


        }

        

        public static async Task AddPermissionClaim(this RoleManager<IdentityRole> roleManager, IdentityRole role, string module)
        {
            var allClaims = await roleManager.GetClaimsAsync(role);
            var allPermissions = Permissions.GeneratePermissionsForModule(module);
            foreach (var permission in allPermissions)
            {
                if (!allClaims.Any(a => a.Type == "Permission" && a.Value == permission))
                {
                     roleManager.AddClaimAsync(role, new Claim("Permission", permission)).GetAwaiter().GetResult();
                }
            }
        }
    }
}