using Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Distributor.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Agent.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Store.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Service_Center.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Customer.ToString()));
        }

        //public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    //Seed Default User
        //    var defaultUser = new ApplicationUser
        //    {
        //        UserName = "Admin",
        //        Email = "admin@gmail.com",
        //        FirstName = "Danny",
        //        LastName = "Eagle",
        //        EmailConfirmed = true,
        //        PhoneNumberConfirmed = true
        //    };
        //    if (userManager.Users.All(u => u.Id != defaultUser.Id))
        //    {
        //        var user = await userManager.FindByEmailAsync(defaultUser.Email);
        //        if (user == null)
        //        {
        //            await userManager.CreateAsync(defaultUser, "Danny@04");
        //            await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
        //           }

        //    }
        //}

    }

}
