using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts(bool trackChanges);
        ProductDto GetProduct(Guid productId, bool trackChanges);
        ProductDto CreateProduct(ProductCreationDto product);
        IEnumerable<ProductDetailDto> GetAllProductDetails(bool trackChanges);
        ProductDetailDto GetProductDetail(Guid productDetailId, bool trackChanges);
        ProductDetailDto CreateProductDetail(ProductDetailCreationDto productDetailCreationDto);
    }
}
