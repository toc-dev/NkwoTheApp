using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class CART:BASE_ENTITY
    {
        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid? ProductDetailId { get; set; }
        public Guid BuyerId { get; set; }
        public int Quantity { get; set; }
        public OrderStatus OrderStatus { get; set; }
        [ForeignKey("BuyerId")]
        public BUYER? Buyer { get; set; }

        [ForeignKey("ProductDetailsId")]
        public PRODUCT_DETAIL? ProductDetail { get; set; }
    }
}
