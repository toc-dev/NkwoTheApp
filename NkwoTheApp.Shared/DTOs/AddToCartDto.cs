using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record AddToCartDto(string ProductName, string SellerName, string ShopName, int Quantity);
}
