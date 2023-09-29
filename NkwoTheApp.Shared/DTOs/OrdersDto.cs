using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record OrdersDto
    {
        public string OrderReference { get; init; }
        public string BuyerName { get; init; }
        public decimal TotalAmount { get; init; }
        public IEnumerable<CartDto> Orders { get; init; }
    }
}
