using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsDevs.Data
{
    public class AppDbContextIdentity : IdentityDbContext<IdentityUser>
    {
        public AppDbContextIdentity(DbContextOptions<AppDbContextIdentity> options) : base(options)
        {

        }

        public static async Task CreateDefaultAdmin(IServiceProvider _serviceProvider , IConfiguration _configuration)
        {
            UserManager<IdentityUser> _userManager =   _serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> _roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string name = _configuration["Data:AdminUser:Name"];
            string email = _configuration["Data:AdminUser:Email"];
            string password = _configuration["Data:AdminUser:Password"];
            string role = _configuration["Data:AdminUser:Role"];

            if(await _roleManager.FindByNameAsync(role) == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }

            if(await _userManager.FindByNameAsync(name) == null)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = name,
                    Email = email
                };

                var result = await _userManager.CreateAsync(user, password);
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
