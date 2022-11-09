using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Exceptions
{
    public sealed class SellerNotFoundException: NotFoundException
    {
        public SellerNotFoundException(Guid sellerId)
            :base($"The seller with the id: {sellerId} does not exist in our records.")
        {

        }
    }
}
