using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.EntitysInit
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "891c0721-f23b-49c2-bbda-3e59b0c20f38"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    Id = "5d61cf78-e527-43bd-92ec-35518c889ac9"
                }
            );
        }
    }
}
