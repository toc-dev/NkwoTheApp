using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Interfaces
{
    public interface IProductDetailRepository
    {
        IEnumerable<PRODUCT_DETAIL> GetAllProductDetails(bool trackChanges);
        PRODUCT_DETAIL GetProductDetail(Guid productDetailId, bool trackChanges);
        void CreateProductDetail(PRODUCT_DETAIL productDetail);
        void DeleteProductDetail(Guid productDetailId);
    }
}
