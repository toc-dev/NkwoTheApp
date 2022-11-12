using AutoMapper;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Domain.Enums;
using NkwoTheApp.Persistence.Repository.Interfaces;
using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Services
{
    internal sealed class ProductService: IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public ProductDto CreateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> GetAllProducts(bool trackChanges)
        {
            var products = _repositoryManager.Product.GetAllProducts(trackChanges);
            var productsDto = products.Select(p => new ProductDto
            {
                Id = p.Id.ToString(),
                Name = p.Name,
                ProductCategory = Enum.GetName(typeof(ProductCategory), p.Category),
                ShopName = p.ProductDetails.ShopName,
                SellerName = p.ProductDetails.Seller.User.FirstName + p.ProductDetails.Seller.User.FirstName,
                SellerEmail = p.ProductDetails.Seller.User.EmailAddress,
                SellerPhone = p.ProductDetails.Seller.User.PhoneNumber
            }).ToList();

            return productsDto;
        }

        public ProductDto GetProduct(Guid productId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
