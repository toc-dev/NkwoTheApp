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
    internal class ProductDetailsConfiguration : IEntityTypeConfiguration<PRODUCT_DETAIL>
    {
        public void Configure(EntityTypeBuilder<PRODUCT_DETAIL> builder)
        {
            builder.HasData
            (
                new PRODUCT_DETAIL
                {
                    Id = new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"),
                    ProductId = new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Agamemnon And Sons",
                    Quantity = 40,
                    Price = 1045.00M,
                    CreatedAt = DateTime.Now
                },
                
                new PRODUCT_DETAIL
                {
                    Id = new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"),
                    ProductId = new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Lojiks Ventures",
                    Quantity = 50,
                    Price = 50.00M,
                    CreatedAt = DateTime.Now
                },
                
                new PRODUCT_DETAIL
                {
                    Id = new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"),
                    ProductId = new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Agamemnon And Sons",
                    Quantity = 500,
                    Price = 90.00M,
                    CreatedAt = DateTime.Now
                },
                
                new PRODUCT_DETAIL
                {
                    Id = new Guid("19e4ba4a-71f0-4390-8854-43dc041ebaa2"),
                    ProductId = new Guid("b7dffa97-da56-4cbb-b5b3-93de39f0e06c"),
                    SellerId = new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"),
                    ShopName = "Agamemnon And Sons",
                    Quantity = 500,
                    Price = 90.00M,
                    CreatedAt = DateTime.Now
                },

                new PRODUCT_DETAIL
                {
                    Id = new Guid("2356b868-a13e-445d-9404-f1401e3f0faf"),
                    ProductId = new Guid("deb46b24-6a60-4f9a-90f7-6f9d3314cb60"),
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
