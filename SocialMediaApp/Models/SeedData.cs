using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialMediaApp.Data;
using System.Collections.Generic;

namespace SocialMediaApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider
                .GetRequiredService <DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Roles.Any())
                {
                    return;
                }

                context.Roles.AddRange(

                    new IdentityRole
                    {
                        Id = "239daf37-31bd-42c4-9f11-8320737429cc", 
                        Name = "Admin", 
                        NormalizedName = "Admin".ToUpper() 
                    },

                    new IdentityRole
                    {
                        Id = "38d898da-719a-4b6c-bde8-905712ada7e7", 
                        Name = "User", 
                        NormalizedName = "User".ToUpper() 
                    }

                );

                var hasher = new PasswordHasher<ApplicationUser>();

                context.Users.AddRange(
                    new ApplicationUser
                    {
                        Id = "00974e5c-2d38-4fc2-8745-e88ceba0d3ba",
                        UserName = "admin@test.com",
                        EmailConfirmed = true,
                        NormalizedEmail = "ADMIN@TEST.COM",
                        Email = "admin@test.com",
                        NormalizedUserName = "ADMIN@TEST.COM",
                        PasswordHash = hasher.HashPassword(null, "Admin1!")
                    },

                    new ApplicationUser
                    {
                        Id = "45b7d85f-53f2-4f8c-b4eb-ea70f3c2276e",
                        UserName = "user@test.com",
                        EmailConfirmed = true,
                        NormalizedEmail = "USER@TEST.COM",
                        Email = "user@test.com",
                        NormalizedUserName = "USER@TEST.COM",
                        PasswordHash = hasher.HashPassword(null, "User1!")
                    },

                    new ApplicationUser
                    {
                        Id = "9807aab3-397d-41d4-8efb-13fc06ffee5a",
                        UserName = "user@test.com",
                        EmailConfirmed = true,
                        NormalizedEmail = "USER@TEST.COM",
                        Email = "user@test.com",
                        NormalizedUserName = "USER@TEST.COM",
                        PasswordHash = hasher.HashPassword(null, "User1!")
                    }
                );

                context.UserRoles.AddRange(
                    new IdentityUserRole<string>
                    {
                        UserId = "00974e5c-2d38-4fc2-8745-e88ceba0d3ba",
                        RoleId = "239daf37-31bd-42c4-9f11-8320737429cc"
                    },

                    new IdentityUserRole<string>
                    {
                        UserId = "45b7d85f-53f2-4f8c-b4eb-ea70f3c2276e",
                        RoleId = "38d898da-719a-4b6c-bde8-905712ada7e7"
                    },

                    new IdentityUserRole<string>
                    {
                        UserId = "9807aab3-397d-41d4-8efb-13fc06ffee5a",
                        RoleId = "38d898da-719a-4b6c-bde8-905712ada7e7"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
