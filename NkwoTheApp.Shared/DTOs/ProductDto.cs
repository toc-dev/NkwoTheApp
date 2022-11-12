using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record ProductDto( string Id, string Name, string ProductCategory, string ShopName,
        string SellerName, string SellerPhone, string SellerEmail );
}
