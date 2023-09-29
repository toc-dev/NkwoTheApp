using AutoMapper;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Domain.Enums;
using NkwoTheApp.Domain.Exceptions;
using NkwoTheApp.Domain.Models;
using NkwoTheApp.Persistence.Repository.Interfaces;
using NkwoTheApp.Shared.DTOs;
using NkwoTheApp.Shared.ThirdPartyServices.Interfaces;
using NkwoTheApp.Shared.ThirdPartyServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Services
{
    internal sealed class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        private readonly IReferenceGenerator _referenceGenerator;

        public OrderService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper,
            IReferenceGenerator referenceGenerator)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
            _referenceGenerator = referenceGenerator;
        }

        public CartDto AddToCart(AddToCartDto cart, bool trackChanges)
        {

            var cartEntity = new CART
            {
                SessionId = cart.SessionId,
                ProductDetailId = cart.ProductDetailId,
                BuyerId = cart.BuyerId,
                Quantity = cart.Quantity,
                OrderStatus = OrderStatus.PENDING
            };
            _repositoryManager.Cart.AddToCart(cartEntity);
            _repositoryManager.Save();
            var cartToReturn = new CartDto
            {
                Id = cartEntity.Id,
                ProductName = cartEntity.ProductDetail.Product.Name,
                SellerName = cartEntity.ProductDetail.Seller.User.FirstName + cartEntity.ProductDetail.Seller.User.LastName,
                ShopName = cartEntity.ProductDetail.ShopName,
                Price = cartEntity.ProductDetail.Price,
                Quantity = cartEntity.Quantity,
            };
            return cartToReturn;
            
        }

       

        public IEnumerable<CartDto> GetAllCartsBySession(Guid sessionId, bool trackChanges)
        {
            var cartItems = _repositoryManager.Cart.GetCartsBySessionId(sessionId, trackChanges);
            if(cartItems == null)
                throw new ItemNotFoundException(sessionId, "cart items");
            var cartDto = cartItems.Select(c => new CartDto()
            {
                Id = c.Id,
                ProductName = c.ProductDetail.Product.Name,
                SellerName = c.ProductDetail.Seller.User.FirstName + c.ProductDetail.Seller.User.LastName,
                ShopName = c.ProductDetail.ShopName,
                Price = c.ProductDetail.Price,
                Quantity = c.ProductDetail.Quantity,
            });
            return cartDto;
        }
        public IEnumerable<CartDto> GetAllCartsByBuyerId(Guid buyerId, bool trackChanges)
        {
            var cartItems = _repositoryManager.Cart.GetCartsByBuyerId(buyerId, trackChanges);
            if (cartItems == null)
                throw new ItemNotFoundException(buyerId, "cart items");
            var cartDto = cartItems.Select(c => new CartDto()
            {
                Id = c.Id,
                BuyerName = c.Buyer.User.FirstName + c.Buyer.User.LastName,
                ProductName = c.ProductDetail.Product.Name,
                SellerName = c.ProductDetail.Seller.User.FirstName + c.ProductDetail.Seller.User.LastName,
                ShopName = c.ProductDetail.ShopName,
                Price = c.ProductDetail.Price,
                Quantity = c.ProductDetail.Quantity,
            });
            return cartDto;
        }

        public IEnumerable<CartDto> GetAllCarts(bool trackChanges)
        {
            var carts = _repositoryManager.Cart.GetAllCarts(trackChanges);
            var cartDto = carts.Select(c => new CartDto()
            {
                Id = c.Id,
                ProductName = c.ProductDetail.Product.Name,
                SellerName = c.ProductDetail.Seller.User.FirstName + c.ProductDetail.Seller.User.LastName,
                ShopName = c.ProductDetail.ShopName,
                Price = c.ProductDetail.Price,
                Quantity = c.ProductDetail.Quantity,
            });
            return cartDto;
        }

        public CartDto GetCart(Guid cartId, bool trackChanges)
        {
            var cart = _repositoryManager.Cart.GetCart(cartId, trackChanges);
            if (cart == null)
                throw new ItemNotFoundException(cartId, "cart");
            var cartDto = new CartDto()
            {
                Id = cart.Id,
                ProductName = cart.ProductDetail.Product.Name,
                SellerName = cart.ProductDetail.Seller.User.FirstName + cart.ProductDetail.Seller.User.LastName,
                ShopName = cart.ProductDetail.ShopName,
                Price = cart.ProductDetail.Price,
                Quantity = cart.ProductDetail.Quantity,
            };

            return cartDto;
        }

        public CartDto Pay(CART cart, bool trackChanges)
        {
            // might do a patch statement here
            //var cart = _repositoryManager.Cart.GetCart(cartId, trackChanges);
            cart.OrderStatus = OrderStatus.PAID;
            _repositoryManager.Cart.AddToCart(cart);
            _repositoryManager.Save();

            var cartToReturn = new CartDto
            {
                Id = cart.Id,
                ProductName = cart.ProductDetail.Product.Name,
                SellerName = cart.ProductDetail.Seller.User.FirstName + cart.ProductDetail.Seller.User.LastName,
                ShopName = cart.ProductDetail.ShopName,
                Price = cart.ProductDetail.Price,
                Quantity = cart.Quantity,
            };
            return cartToReturn;
        }

        public void Checkout(bool trackChanges)
        {
            var carts = _repositoryManager.Cart.GetAllCarts(trackChanges).ToList();
            //var ids = from cart in carts
            //          select cart.Id;
            //mapper
            foreach (var cart in carts)
            {
                Pay(cart, trackChanges);
            }

        }

        public CartDto ConfirmPayment(Guid cartId, bool trackChanges)
        {
            // might do a patch statement here
            var cart = _repositoryManager.Cart.GetCart(cartId, trackChanges);
            cart.OrderStatus = OrderStatus.PROCESSING;
            _repositoryManager.Cart.AddToCart(cart);
            _repositoryManager.Save();
            var cartToReturn = new CartDto
            {
                Id = cart.Id,
                ProductName = cart.ProductDetail.Product.Name,
                SellerName = cart.ProductDetail.Seller.User.FirstName + cart.ProductDetail.Seller.User.LastName,
                ShopName = cart.ProductDetail.ShopName,
                Price = cart.ProductDetail.Price,
                Quantity = cart.Quantity,
            };
            return cartToReturn;
        }

        public CartDto ConfirmReceiptofProduct(Guid cartId, bool trackChanges)
        {
            // might do a patch statement here
            var cart = _repositoryManager.Cart.GetCart(cartId, trackChanges);
            cart.OrderStatus = OrderStatus.COMPLETED;
            _repositoryManager.Cart.AddToCart(cart);
            _repositoryManager.Save();
            var cartToReturn = new CartDto
            {
                Id = cart.Id,
                ProductName = cart.ProductDetail.Product.Name,
                SellerName = cart.ProductDetail.Seller.User.FirstName + cart.ProductDetail.Seller.User.LastName,
                ShopName = cart.ProductDetail.ShopName,
                Price = cart.ProductDetail.Price,
                Quantity = cart.Quantity,
            };
            return cartToReturn;
        }

        public CartDto RemoveFromCart(Guid cartId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public OrdersDto ReturnOrders(Guid buyerId, bool trackChanges)
        {
            //order reference cannot be generated at the point of returning orders
            var orders = GetAllCartsByBuyerId(buyerId, trackChanges);
            var ordersDto = new OrdersDto()
            {
                OrderReference = _referenceGenerator.GenerateReference(),
                BuyerName = orders.FirstOrDefault().BuyerName,
                TotalAmount = CalculateTotalFromBuyer(buyerId, trackChanges),
                Orders = orders
            };
            return ordersDto;
        }

        private decimal CalculateTotal(Guid sessionId, bool trackChanges)
        {
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in GetAllCartsBySession(sessionId, trackChanges)
                               select cartItems.Price * cartItems.Quantity).Sum();

            return total.Value;
        }
        
        private decimal CalculateTotalFromBuyer(Guid buyerId, bool trackChanges)
        {
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in GetAllCartsBySession(buyerId, trackChanges)
                               select cartItems.Price * cartItems.Quantity).Sum();

            return total.Value;
        }
    }
}
