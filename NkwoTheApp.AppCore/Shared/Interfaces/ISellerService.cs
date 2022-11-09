using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Interfaces
{
    public interface ISellerService
    {
        IEnumerable<SellerDto> GetAllSellers(bool trackChanges);
        SellerDto GetSeller(Guid sellerId, bool trackChanges);
    }
}
