using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record ProductDetailDto
    {
        public Guid Id { get; init; }
        public string ProductName { get; init; }
        public string SellerName { get; init; }
        public string ShopName { get; init; }
        public int Quantity { get; init; }
        public decimal Price { get; init; }
    }
        
}
