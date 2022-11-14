using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<ADDRESS>
    {
        public void Configure(EntityTypeBuilder<ADDRESS> builder)
        {
            builder.HasData
            (
                new ADDRESS
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Country = "Nigeria",
                    Region = "South-East",
                    City = "Enugu",
                    Street = "Nza Street",
                    StreetNumber = "24"
                }, 
                
                new ADDRESS
                {
                    Id = new Guid("1246b007-018b-4028-aff8-dcc4bd1aec68"),
                    Country = "Ukraine",
                    Region = "Donbas",
                    City = "Kyiv",
                    Street = "Spazosevic street",
                    StreetNumber = "1213"
                }
            );
        }
    }
}
