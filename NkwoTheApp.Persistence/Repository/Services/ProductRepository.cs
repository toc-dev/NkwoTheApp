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
    public class ProductRepository : RepositoryBase<PRODUCT>, IProductRepository
    {
        public ProductRepository(NkwoTheAppContext nkwoTheAppContext)
            :base(nkwoTheAppContext)
        {

        }
        public void CreateProduct(PRODUCT product)
        {
            Create(product);
        }

        public void DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PRODUCT> GetAllProducts(bool trackChanges)
        {
            return GetAll(trackChanges)
                .OrderBy(p=>p.Category)
                .ToList();
        }

        public PRODUCT GetProduct(Guid productId, bool trackChanges)
        {
            return GetByCondition(p => p.Id.Equals(productId), trackChanges)
                .SingleOrDefault();
        }
    }
}
