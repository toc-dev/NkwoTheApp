using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Interfaces
{
    public interface IBuyerRepository
    {
        IEnumerable<BUYER> GetAllBuyers(bool trackChanges);
        BUYER GetBuyer(Guid buyerId, bool trackChanges);
        void CreateBuyer(BUYER buyer);
        void DeleteBuyer(Guid buyerId);
    }
}
