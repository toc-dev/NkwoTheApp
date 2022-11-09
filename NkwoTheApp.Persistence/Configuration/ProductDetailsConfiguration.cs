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
    internal class ProductDetailsConfiguration : IEntityTypeConfiguration<PRODUCT_DETAILS>
    {
        public void Configure(EntityTypeBuilder<PRODUCT_DETAILS> builder)
        {
            builder.HasData
            (
                new PRODUCT_DETAILS
                {
                    Id = new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Agamemnon And Sons",
                    Quantity = 40,
                    Price = 1045.00M,
                    CreatedAt = DateTime.Now
                },
                
                new PRODUCT_DETAILS
                {
                    Id = new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Agamemnon And Sons",
                    Quantity = 50,
                    Price = 50.00M,
                    CreatedAt = DateTime.Now
                },
                
                new PRODUCT_DETAILS
                {
                    Id = new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Agamemnon And Sons",
                    Quantity = 500,
                    Price = 90.00M,
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}
