using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.EntitysInit
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    CreateBy = "System",
                    Name = "RED",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 1
                },
                new Colour
                {
                    CreateBy = "System",
                    Name = "BLACK",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 2
                },
                new Colour
                {
                    CreateBy = "System",
                    Name = "BLUE",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 3
                },
                new Colour
                {
                    CreateBy = "System",
                    Name = "WHITE",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 4
                }
            );
            
        }
    }
}
