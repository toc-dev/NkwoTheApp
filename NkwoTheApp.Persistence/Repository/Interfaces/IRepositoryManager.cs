using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Interfaces
{
    public interface IRepositoryManager
    {

        public IBuyerRepository Buyer { get; }
        public ISellerRepository Seller { get; }
        public IProductRepository Product { get; }
        public IProductDetailRepository ProductDetail { get; }
        public ICartRepository Cart { get; }
        void Save();
    }
}
