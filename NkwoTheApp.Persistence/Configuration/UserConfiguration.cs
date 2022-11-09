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
    public class UserConfiguration: IEntityTypeConfiguration<USER>
    {
        public void Configure(EntityTypeBuilder<USER> builder)
        {
            builder.HasData
            (
                new USER
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    AddressId = new Guid("1246b007-018b-4028-aff8-dcc4bd1aec68"),
                    FirstName = "Marinko",
                    LastName = "Spazevovic",
                    Username = "iberia",
                    EmailAddress = "iberia@gmail.com",
                    PhoneNumber = "+21-345-4567-987",
                    PersonType = Domain.Enums.PersonType.Buyer,
                    Gender = Domain.Enums.Gender.Male,

                },
                new USER
                {
                    Id = new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab"),
                    AddressId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    FirstName = "Tochukwu",
                    LastName = "Nwokolo",
                    Username = "tochukwusage",
                    EmailAddress = "tochukwusage@gmail.com",
                    PhoneNumber = "+234-706-5432-123",
                    PersonType = Domain.Enums.PersonType.Seller,
                    Gender = Domain.Enums.Gender.Male,
                }
            );
        }
    }
}

//same for other tables in the db
//pg 53 Marinko, 77
