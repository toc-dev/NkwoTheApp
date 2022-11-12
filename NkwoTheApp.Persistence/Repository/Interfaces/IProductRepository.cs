using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<PRODUCT> GetAllProducts(bool trackChanges);
        PRODUCT GetProduct(string productId, bool trackChanges);
        void CreateProduct(PRODUCT product);
        void DeleteProduct(Guid productId);
    }
}
