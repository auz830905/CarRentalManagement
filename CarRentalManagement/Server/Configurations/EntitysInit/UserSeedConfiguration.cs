using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.EntitysInit
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "748b708f-69a3-45b5-b520-a95fe1417016",
                    Email = "yeli@gmail.com",
                    NormalizedEmail = "YELI@GMAIL.COM",
                    UserName = "yeli@gmail.com",
                    NormalizedUserName = "YELI@GMAIL.COM",
                    FistName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Fermat&1"),
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new ApplicationUser
                {
                    Id = "748b708f-69a3-45b5-b520-a95fe1417017",
                    Email = "adael@gmail.com",
                    NormalizedEmail = "ADAEL@GMAIL.COM",
                    UserName = "adael@gmail.com",
                    NormalizedUserName = "ADAEL@GMAIL.COM",
                    FistName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Fermat&1"),
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                }
            );
        }
    }
}
