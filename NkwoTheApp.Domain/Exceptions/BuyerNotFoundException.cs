using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Exceptions
{
    public sealed class BuyerNotFoundException: NotFoundException
    {
        public BuyerNotFoundException(Guid buyerId)
            :base($"The buyer with id: {buyerId} does not exist in our records.")
        {

        }
    }
}
