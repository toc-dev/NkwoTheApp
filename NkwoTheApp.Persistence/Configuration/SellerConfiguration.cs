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
    public class SellerConfiguration : IEntityTypeConfiguration<SELLER>
    {
        public void Configure(EntityTypeBuilder<SELLER> builder)
        {
            builder.HasData
            (
                new SELLER
                {
                    Id = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    UserId =  new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab"),
                    RegistrationStatus = Domain.Enums.RegistrationStatus.Completed
                }
            );
        }
    }
}
