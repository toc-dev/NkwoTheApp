using Microsoft.EntityFrameworkCore;
using NkwoTheApp.Domain.Models;
using NkwoTheApp.Persistence.Context;
using NkwoTheApp.Persistence.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Services
{
    public class SellerRepository : RepositoryBase<SELLER>, ISellerRepository
    {
        public SellerRepository(NkwoTheAppContext nkwoTheAppContext)
            : base(nkwoTheAppContext)
        {

        }

        public IEnumerable<SELLER> GetAllSellers(bool trackChanges)
        {
            return GetAll(trackChanges)
                .Include(seller => seller.User)
                .ThenInclude(user => user.Address)
                .OrderBy(s => s.User.Username)
                .ToList();
        }

        public SELLER GetSeller(Guid sellerId, bool trackChanges)
        {
            return GetByCondition(s => s.Id.Equals(sellerId), trackChanges)
                .Include(seller => seller.User)
                .ThenInclude(user => user.Address)
                .SingleOrDefault();
        }
    }
}
