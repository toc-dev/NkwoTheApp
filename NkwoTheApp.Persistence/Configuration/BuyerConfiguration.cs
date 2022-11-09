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
    public class BuyerConfiguration : IEntityTypeConfiguration<BUYER>
    {
        public void Configure(EntityTypeBuilder<BUYER> builder)
        {
            builder.HasData
            (
                new BUYER
                {
                    Id = new Guid("2dc01af8-ffc3-4468-b80d-38d6fef11b34"),
                    UserId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    RegistrationStatus = Domain.Enums.RegistrationStatus.Completed
                }
            );
        }
    }
}
