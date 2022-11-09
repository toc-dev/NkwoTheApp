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
    public class BuyerRepository: RepositoryBase<BUYER>, IBuyerRepository
    {
        public BuyerRepository(NkwoTheAppContext nkwoTheAppContext)
           : base(nkwoTheAppContext)
        {

        }

        public IEnumerable<BUYER> GetAllBuyers(bool trackChanges)
        {
            return GetAll(trackChanges)
                .Include(buyer=>buyer.User)
                .ThenInclude(user=>user.Address)
                .OrderBy(b => b.User.Username)
                .ToList();
        }

        public BUYER GetBuyer(Guid buyerId, bool trackChanges)
        {
            return GetByCondition(b => b.Id.Equals(buyerId), trackChanges)
                .Include(buyer=>buyer.User)
                .ThenInclude(user=>user.Address)
                .SingleOrDefault();
        }
    }
}
