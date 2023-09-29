using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Exceptions
{
    public sealed class ItemNotFoundException: NotFoundException
    {
        public ItemNotFoundException(Guid itemId, string itemName)
            :base($"The {itemName} with id: {itemId} does not exist in our records.")
        {

        }
    }
}
