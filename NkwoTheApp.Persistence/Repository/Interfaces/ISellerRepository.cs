using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Interfaces
{
    public interface ISellerRepository
    {
        IEnumerable<SELLER> GetAllSellers(bool trackChanges);
        SELLER GetSeller(Guid sellerId, bool trackChanges);
    }
}
