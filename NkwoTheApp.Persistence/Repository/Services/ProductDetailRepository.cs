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
    public class ProductDetailRepository : RepositoryBase<PRODUCT_DETAIL>, IProductDetailRepository
    {
        public ProductDetailRepository(NkwoTheAppContext nkwoTheAppContext)
            :base(nkwoTheAppContext)
        {

        }
        public void CreateProductDetail(PRODUCT_DETAIL productDetail)
        {
            Create(productDetail);
        }

        public void DeleteProductDetail(Guid productDetailId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PRODUCT_DETAIL> GetAllProductDetails(bool trackChanges)
        {
            return GetAll(trackChanges)
                .Include(productDetail=> productDetail.Product)
                .Include(productDetail=>productDetail.Seller)
                .ThenInclude(seller=>seller.User)
                .OrderBy(p=>p.ProductId)
                .ToList();
        }

        public PRODUCT_DETAIL GetProductDetail(Guid productDetailId, bool trackChanges)
        {
            return GetByCondition(p=>p.Id.Equals(productDetailId), trackChanges)
                .Include(productDetail => productDetail.Product)
                .Include(productDetail => productDetail.Seller)
                .ThenInclude(seller => seller.User)
                .OrderBy(p => p.ProductId)
                .SingleOrDefault();
        }
    }
}
