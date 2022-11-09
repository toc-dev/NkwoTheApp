using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class PRODUCT_DETAILS: BASE_ENTITY
    {
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public string? ShopName { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(20,8)")]
        public decimal Price { get; set; }
        [ForeignKey("SellerId")]
        public SELLER? Seller { get; set; }
        
    }
}
