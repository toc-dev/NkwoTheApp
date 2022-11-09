using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class PRODUCT: BASE_ENTITY
    {
        public Guid Id { get; set; }
        public Guid ProductDetailsId { get; set; }
        public string? Name { get; set; }
        public ProductCategory Category { get; set; }
        [ForeignKey("ProductDetailsId")]
        public PRODUCT_DETAILS? ProductDetails { get; set; }

    }
}
