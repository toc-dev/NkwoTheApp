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
    public class CartRepository: RepositoryBase<CART>, ICartRepository
    {
        public CartRepository(NkwoTheAppContext nkwoTheAppContext)
            :base(nkwoTheAppContext)
        {

        }

        public void AddToCart(CART cart)
        {
            Create(cart);
        }

        public IEnumerable<CART> GetAllCarts(bool trackChanges)
        {
            return GetAll(trackChanges)
                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Product)

                .Include(cart=>cart.ProductDetail)
                .ThenInclude(productDetail=>productDetail.Seller)
                .ThenInclude(seller=>seller.User)

                .Include(cart => cart.Buyer)
                .ThenInclude(buyer => buyer.User)

                .OrderBy(p => p.BuyerId)
                .ToList();
        }

        public IEnumerable<CART> GetCartsBySessionId(Guid sessionId, bool trackChanges)
        {
            return GetByCondition(c => c.SessionId.Equals(sessionId), trackChanges)
                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Product)

                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Seller)
                .ThenInclude(seller => seller.User)

                .Include(cart => cart.Buyer)
                .ThenInclude(buyer => buyer.User)

                .OrderBy(p => p.BuyerId)
                .ToList(); ;
        }
        public IEnumerable<CART> GetCartsByBuyerId(Guid buyerId, bool trackChanges)
        {
            return GetByCondition(c => c.SessionId.Equals(buyerId), trackChanges)
                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Product)

                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Seller)
                .ThenInclude(seller => seller.User)

                .Include(cart => cart.Buyer)
                .ThenInclude(buyer => buyer.User)

                .OrderBy(p => p.BuyerId)
                .ToList(); ;
        }

        public CART GetCart(Guid cartId, bool trackChanges)
        {
            return GetByCondition(c=>c.Id.Equals(cartId), trackChanges)
                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Product)

                .Include(cart => cart.ProductDetail)
                .ThenInclude(productDetail => productDetail.Seller)
                .ThenInclude(seller => seller.User)

                .Include(cart => cart.Buyer)
                .ThenInclude(buyer => buyer.User)

                .OrderBy(p => p.BuyerId)
                .SingleOrDefault();
        }

        public void RemoveFromCart(CART cart)
        {
            throw new NotImplementedException();
        }
    }
}
