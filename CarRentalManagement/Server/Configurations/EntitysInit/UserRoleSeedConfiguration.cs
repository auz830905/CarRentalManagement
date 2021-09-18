using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.EntitysInit
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "748b708f-69a3-45b5-b520-a95fe1417016",
                    RoleId = "5d61cf78-e527-43bd-92ec-35518c889ac9"
                },
                new IdentityUserRole<string>
                {
                    UserId = "748b708f-69a3-45b5-b520-a95fe1417017",
                    RoleId = "891c0721-f23b-49c2-bbda-3e59b0c20f38"
                }
            );
        }
    }
}
