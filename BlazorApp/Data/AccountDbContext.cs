using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data;

public class AccountDbContext : IdentityDbContext
{
    public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        string adminRoleId = Guid.NewGuid().ToString();
        string userRoleId = Guid.NewGuid().ToString();

        var roles = new List<IdentityRole>
        {
            new IdentityRole {
                Name = "Admin",
                NormalizedName = "Admin",
                Id = adminRoleId

            },
            new IdentityRole{
                Name = "User",
                NormalizedName = "User",
                Id = userRoleId
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);

        string adminUserId = Guid.NewGuid().ToString();
        var user = new IdentityUser
        {
            UserName = "Admin",
            NormalizedUserName = "Admin",
            Email = "admin@gmail.com",
            Id = adminUserId
        };
        user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, "Admin@123");

        builder.Entity<IdentityUser>().HasData(user);

        //Add all roles to admin
        var userRoles = new List<IdentityUserRole<string>>(){
                new IdentityUserRole<string>
                {
                    
                    RoleId = adminRoleId,
                    UserId = adminUserId
                },
                 new IdentityUserRole<string>{
                    RoleId = userRoleId,
                    UserId = adminUserId
                }
            };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    }
}
