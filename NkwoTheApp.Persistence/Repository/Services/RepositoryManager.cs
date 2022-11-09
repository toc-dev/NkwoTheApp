using NkwoTheApp.Persistence.Context;
using NkwoTheApp.Persistence.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Services
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly NkwoTheAppContext _nkwoTheAppContext;
        private readonly Lazy<ISellerRepository> _sellerRepository;
        private readonly Lazy<IBuyerRepository> _buyerRepository;

        public RepositoryManager(NkwoTheAppContext nkwoTheAppContext)
        {
            _nkwoTheAppContext = nkwoTheAppContext;
            _sellerRepository = new Lazy<ISellerRepository>(() => new SellerService(nkwoTheAppContext));
            _buyerRepository = new Lazy<IBuyerRepository>(() => new BuyerRepository(nkwoTheAppContext));
        }
        public IBuyerRepository Buyer => _buyerRepository.Value;

        public ISellerRepository Seller => _sellerRepository.Value;

        public void Save()
        {
            _nkwoTheAppContext.SaveChanges();
        }
    }
}
