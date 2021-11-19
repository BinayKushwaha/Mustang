using Microsoft.AspNetCore.Identity;
using Mustang.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.Helper
{
    public static class IdentityDataInitializer
    {
         public static void SeedIdentity(UserManager<ApplicationUser> userManager
            ,RoleManager<IdentityRole> roleManager)
        {
            SeedRole(roleManager);
            SeedUser(userManager);
        }
        public static void SeedUser(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("Jagesh.Maharjan@cotiviti.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Jagesh.Maharjan@cotiviti.com";
                user.Email = "Jagesh.Maharjan@cotiviti.com";
                user.EmailConfirmed = true;
                user.SecurityStamp = Guid.NewGuid().ToString();

                var passwordHaser = new PasswordHasher<ApplicationUser>();
                var hashedPassword = passwordHaser.HashPassword(user, "P@ssword1");

                user.PasswordHash = hashedPassword;
                var result = userManager.CreateAsync(user);
                if (result.Result.Succeeded)
                    userManager.AddToRoleAsync(user, Enum.UserRole.Administrator.ToString()).Wait();
            }
            if (userManager.FindByNameAsync("Satish.Sahani@cotiviti.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Satish.Sahani@cotiviti.com";
                user.Email = "Satish.Sahani@cotiviti.com";
                user.EmailConfirmed = true;
                user.SecurityStamp = Guid.NewGuid().ToString();

                var passwordHaser = new PasswordHasher<ApplicationUser>();
                var hashedPassword = passwordHaser.HashPassword(user, "P@ssword1");

                user.PasswordHash = hashedPassword;
                var result=userManager.CreateAsync(user);
                if (result.Result.Succeeded)
                    userManager.AddToRoleAsync(user, Enum.UserRole.Administrator.ToString()).Wait();
            }
            if (userManager.FindByNameAsync("Bindu.Karki@cotiviti.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Bindu.Karki@cotiviti.com";
                user.Email = "Bindu.Karki@cotiviti.com";
                user.EmailConfirmed = true;
                user.SecurityStamp = Guid.NewGuid().ToString();

                var passwordHaser = new PasswordHasher<ApplicationUser>();
                var hashedPassword = passwordHaser.HashPassword(user, "P@ssword1");

                user.PasswordHash = hashedPassword;
                var result = userManager.CreateAsync(user);
                if (result.Result.Succeeded)
                    userManager.AddToRoleAsync(user, Enum.UserRole.Administrator.ToString()).Wait();
            }
            if (userManager.FindByNameAsync("Anil.Rokka@cotiviti.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Anil.Rokka@cotiviti.com";
                user.Email = "Anil.Rokka@cotiviti.com";
                user.EmailConfirmed = true;
                user.SecurityStamp = Guid.NewGuid().ToString();

                var passwordHaser = new PasswordHasher<ApplicationUser>();
                var hashedPassword = passwordHaser.HashPassword(user, "P@ssword1");

                user.PasswordHash = hashedPassword;
                var result = userManager.CreateAsync(user);
                if (result.Result.Succeeded)
                    userManager.AddToRoleAsync(user, Enum.UserRole.Administrator.ToString()).Wait();
            }
            if (userManager.FindByNameAsync("Sanju.Parajuli@cotiviti.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Sanju.Parajuli@cotiviti.com";
                user.Email = "Sanju.Parajuli@cotiviti.com";
                user.EmailConfirmed = true;
                user.SecurityStamp = Guid.NewGuid().ToString();

                var passwordHaser = new PasswordHasher<ApplicationUser>();
                var hashedPassword = passwordHaser.HashPassword(user, "P@ssword1");

                user.PasswordHash = hashedPassword;
                var result = userManager.CreateAsync(user);
                if (result.Result.Succeeded)
                    userManager.AddToRoleAsync(user, Enum.UserRole.Administrator.ToString()).Wait();
            }
            if (userManager.FindByNameAsync("Binay.Kushwaha@cotiviti.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Binay.Kushwaha@cotiviti.com";
                user.Email = "Binay.Kushwaha@cotiviti.com";
                user.EmailConfirmed = true;
                user.SecurityStamp = Guid.NewGuid().ToString();

                var passwordHaser = new PasswordHasher<ApplicationUser>();
                var hashedPassword = passwordHaser.HashPassword(user, "P@ssword1");

                user.PasswordHash = hashedPassword;
                var result = userManager.CreateAsync(user);
                if (result.Result.Succeeded)
                    userManager.AddToRoleAsync(user, Enum.UserRole.Administrator.ToString()).Wait();
            }

        }
        public static void SeedRole(RoleManager<IdentityRole> roleManager) 
        {
            if (!roleManager.RoleExistsAsync(Enum.UserRole.Administrator.ToString()).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = Enum.UserRole.Administrator.ToString();
                IdentityResult result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
