using AutoMapper;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Domain.Enums;
using NkwoTheApp.Domain.Exceptions;
using NkwoTheApp.Domain.Models;
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

        public ProductDto CreateProduct(ProductCreationDto product)
        {
            var productEntity = new PRODUCT
            {
                Name = product.Name,
                Category = (ProductCategory)Enum.Parse(typeof(ProductCategory), product.ProductCategory.ToUpper()), 
            };
            _repositoryManager.Product.CreateProduct(productEntity);
            _repositoryManager.Save();
            var productToReturn = new ProductDto
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                ProductCategory = Enum.GetName(typeof(ProductCategory), productEntity.Category),
            };

            return productToReturn;
        }

        

        public IEnumerable<ProductDto> GetAllProducts(bool trackChanges)
        {
            var products = _repositoryManager.Product.GetAllProducts(trackChanges);
            var productsDto = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                ProductCategory = Enum.GetName(typeof(ProductCategory), p.Category),
            }).ToList();

            return productsDto;
        }

        public ProductDto GetProduct(Guid productId, bool trackChanges)
        {
            var product = _repositoryManager.Product.GetProduct(productId, trackChanges);
            if (product is null)
                throw new ProductNotFoundException(productId);
            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                ProductCategory = Enum.GetName(typeof(ProductCategory), product.Category),
            };

            return productDto;
        }

        public ProductDetailDto GetProductDetail(Guid productDetailId, bool trackChanges)
        {
            var productDetail = _repositoryManager.ProductDetail.GetProductDetail(productDetailId, trackChanges);
            if(productDetail is null)
                throw new ProductDetailNotFoundException(productDetailId);
            var productDetailDto = new ProductDetailDto()
            {
                Id = productDetail.Id,
                ProductName = productDetail.Product.Name,
                SellerName = productDetail.Seller.User.FirstName + " " + productDetail.Seller.User.LastName,
                ShopName = productDetail.ShopName,
                Quantity = productDetail.Quantity,
                Price = productDetail.Price,

            };
            return productDetailDto;
        }
        public IEnumerable<ProductDetailDto> GetAllProductDetails(bool trackChanges)
        {
            var productDetails = _repositoryManager.ProductDetail.GetAllProductDetails(trackChanges);
            var productDetailsDto = productDetails.Select(p => new ProductDetailDto()
            {
                Id = p.Id,
                ProductName = p.Product.Name,
                SellerName = p.Seller.User.FirstName + " " + p.Seller.User.LastName,
                ShopName = p.ShopName,
                Quantity = p.Quantity,
                Price = p.Price,

            }).ToList();
            return productDetailsDto;
        }
        public ProductDetailDto CreateProductDetail(ProductDetailCreationDto productDetailCreationDto)
        {
            var productDetailEntity = new PRODUCT_DETAIL
            {
                ProductId = productDetailCreationDto.ProductId,
                SellerId = productDetailCreationDto.SellerId,
                ShopName = productDetailCreationDto.ShopName,
                Quantity = productDetailCreationDto.Quantity,
                Price = productDetailCreationDto.Price,
            };
            _repositoryManager.ProductDetail.CreateProductDetail(productDetailEntity);
            _repositoryManager.Save();
            var productDetailToReturn = new ProductDetailDto()
            {
                Id = productDetailEntity.Id,
                ProductName = productDetailEntity.Product.Name,
                SellerName = productDetailEntity.Seller.User.FirstName + " " + productDetailEntity.Seller.User.LastName,
                ShopName = productDetailEntity.ShopName,
                Quantity = productDetailEntity.Quantity,
                Price = productDetailEntity.Price,
            };
            return productDetailToReturn;
        }
    }
}
