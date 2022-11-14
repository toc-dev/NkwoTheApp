using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Exceptions
{
    public sealed class ProductNotFoundException: NotFoundException
    {
        public ProductNotFoundException(Guid productId)
            :base($"The product with id: {productId} does not exist in our records.")
        {
        }
    }
}
