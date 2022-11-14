using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class PRICE_OFFER: BASE_ENTITY
    {
        public Guid Id { get; set; }
        public Guid ProductDetailsId { get; set; }
        [Column(TypeName = "decimal(20,8)")]
        public decimal NewPrice { get; set; }
        public string? PromotionalText { get; set; }
        [ForeignKey("ProductDetailsId")]
        public PRODUCT_DETAIL? Product { get; set; }
    }
}
