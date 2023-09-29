using NkwoTheApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Interfaces
{
    public interface ICartRepository
    {
        IEnumerable<CART> GetAllCarts(bool trackChanges);
        IEnumerable<CART> GetCartsBySessionId(Guid sessionId, bool trackChanges);
        IEnumerable<CART> GetCartsByBuyerId(Guid sessionId, bool trackChanges);
        CART GetCart(Guid cartId, bool trackChanges);
        void AddToCart(CART cart);
        void RemoveFromCart(CART cart);
    }
}
