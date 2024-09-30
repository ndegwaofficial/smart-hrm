using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHRM.DataAccess.Seeds;
using SmartHRM.Models;
using SmartHRM.Utility.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.DbInitializer
{
    public class DbInitializer: IDbInitializer
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _db;


		public DbInitializer(
			UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			ApplicationDbContext db)
		{
			_db = db;
			_roleManager = roleManager;
			_userManager = userManager;			
		}

		public  async void Initialize()
		{
			//Apply Migrations if not applied
			try
			{
				if (_db.Database.GetPendingMigrations().Count() > 0)
				{
					_db.Database.Migrate();
				}
            }
			catch (Exception ex)
			{

			}

			//Create roles if not created

			if (!_roleManager.RoleExistsAsync(SD.RoleSuperAdmin).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole(SD.RoleSuperAdmin)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(SD.RoleAdmin)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(SD.RoleEmployee)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(SD.RoleBasic)).GetAwaiter().GetResult();


				//If roles are not created, we create Super Admin user as well asn add all roles to him/her
				_userManager.CreateAsync(new ApplicationUser
				{
					UserName = "admin@felsoftsystems.com",
					Email = "admin@felsoftsystems.com",
					FirstName = "Felix",
					LastName = "Aduol",
					PhoneNumber = "0721388689",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,

                }, "Admin123*@P").GetAwaiter().GetResult();

				ApplicationUser userSuper = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin@felsoftsystems.com");
				_userManager.AddToRoleAsync(userSuper, SD.RoleSuperAdmin).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(userSuper, SD.RoleAdmin).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(userSuper, SD.RoleEmployee).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(userSuper, SD.RoleBasic).GetAwaiter().GetResult();

                IdentityRole adminRole = await  _roleManager.FindByNameAsync("SuperAdmin");
                var allClaims = _roleManager.GetClaimsAsync(adminRole);
                var allPermissions = Permissions.GeneratePermissionsForModule("Employee");
                foreach (var permission in allPermissions)
                {                    
                        await _roleManager.AddClaimAsync(adminRole, new Claim("Permission", permission));                   
                }



                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "basic@felsoftsystems.com",
                    Email = "basic@felsoftsystems.com",
                    FirstName = "Kenan",
                    LastName = "Odhiambo",
                    PhoneNumber = "0721388689",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,

                }, "Admin123*@P").GetAwaiter().GetResult();

                ApplicationUser userbasic = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "basic@felsoftsystems.com");
                _userManager.AddToRoleAsync(userbasic, SD.RoleSuperAdmin).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(userbasic, SD.RoleAdmin).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(userbasic, SD.RoleEmployee).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(userbasic, SD.RoleBasic).GetAwaiter().GetResult();
                
            }

			return;
		}

       


    }
}
