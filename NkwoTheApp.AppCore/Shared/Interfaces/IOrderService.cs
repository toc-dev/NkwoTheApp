using NkwoTheApp.Domain.Models;
using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Interfaces
{
    public interface IOrderService
    {
        CartDto AddToCart(AddToCartDto cart, bool trackChanges);
        public IEnumerable<CartDto> GetAllCarts(bool trackChanges);
        IEnumerable<CartDto> GetAllCartsBySession(Guid sessionId, bool trackChanges);
        IEnumerable<CartDto> GetAllCartsByBuyerId(Guid buyerId, bool trackChanges);
        CartDto GetCart(Guid cartId, bool trackChanges);
        CartDto RemoveFromCart(Guid cartId, bool trackChanges);
        CartDto Pay(CART cart, bool trackChanges);
        void Checkout(bool trackChanges);
    }
}
