using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.EntitysInit
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    CreateBy = "System",
                    Name = "Auris",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 1
                },
                new Model
                {
                    CreateBy = "System",
                    Name = "Avensis",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 2
                },
                new Model
                {
                    CreateBy = "System",
                    Name = "Enso",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 3
                },
                new Model
                {
                    CreateBy = "System",
                    Name = "A1",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 4
                },
                new Model
                {
                    CreateBy = "System",
                    Name = "A8",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 5
                },
                new Model
                {
                    CreateBy = "System",
                    Name = "2107",
                    CreateDate = DateTime.Now,
                    UpdateBy = "System",
                    UpdateDate = DateTime.Now,
                    Id = 6

                }
            );
        }
    }
}
