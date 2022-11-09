using NkwoTheApp.Domain.Models;
using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Interfaces
{
    public interface IBuyerService
    {
        IEnumerable<BuyerDto> GetAllBuyers(bool trackChanges);
        BuyerDto GetBuyer(Guid buyerId, bool trackChanges);
    }
}
