using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record CartDto
    {
        public Guid Id { get; init; }
        public string BuyerName { get; init; }
        public string ProductName { get; init; }
        public string SellerName { get; init; }
        public string ShopName { get; init; }
        public decimal Price { get; init; }
        public int Quantity { get; init; }
    }
}
