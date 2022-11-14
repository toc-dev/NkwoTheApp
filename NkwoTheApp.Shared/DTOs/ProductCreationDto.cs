using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record ProductCreationDto(string Name,
        string ProductCategory);

    public record ProductDetailsDto(string ProductId, Guid SellerId, string ShopName,
        int Quantity, decimal Price);
}
