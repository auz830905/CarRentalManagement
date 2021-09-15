using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.EntitysInit
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    CreateBy = "System",
                    Name = "Toyota",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 1
                },
                new Make
                {
                    CreateBy = "System",
                    Name = "BMW",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 2
                },
                new Make
                {
                    CreateBy = "System",
                    Name = "Ferrari",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 3
                },
                new Make
                {
                    CreateBy = "System",
                    Name = "AUDI",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 4
                },
                new Make
                {
                    CreateBy = "System",
                    Name = "Lada",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 5
                }
            );
        }
    }
}
