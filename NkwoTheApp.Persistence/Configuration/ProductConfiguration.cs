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
    public class ProductConfiguration : IEntityTypeConfiguration<PRODUCT>
    {
        public void Configure(EntityTypeBuilder<PRODUCT> builder)
        {
            builder.HasData
            (
                new PRODUCT
                {
                    Id = new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"),
                    Name = "IPhone 14",
                    Category = Domain.Enums.ProductCategory.ELECTRONICS,
                    //ProductDetailsId = new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93")

                },
                
                new PRODUCT
                {
                    Id = new Guid("b7dffa97-da56-4cbb-b5b3-93de39f0e06c"),
                    Name = "Rechargeable Lantern",
                    Category = Domain.Enums.ProductCategory.ELECTRONICS,
                    //ProductDetailsId = new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa")
                },
                
                new PRODUCT
                {
                    Id = new Guid("deb46b24-6a60-4f9a-90f7-6f9d3314cb60"),
                    Name = "Headphone",
                    Category = Domain.Enums.ProductCategory.ELECTRONICS,
                    //ProductDetailsId = new Guid("0d034c9b-8e63-4838-af27-b13be57d1457")
                }
            );
        }     
    }
}
