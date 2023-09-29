using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Enums
{
    public enum OrderStatus
    {
        PENDING = 1,
        PAID,
        PROCESSING,
        CANCELLED,
        COMPLETED
    }
}
