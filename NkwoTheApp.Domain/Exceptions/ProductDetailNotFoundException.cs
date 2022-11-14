using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Exceptions
{
    public sealed class ProductDetailNotFoundException: NotFoundException
    {
        public ProductDetailNotFoundException(Guid productDetailId)
            :base($"The product detail with id: {productDetailId} does not exist in our records")
        {
        }
    }
}
