using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Interfaces
{
    public interface IServiceManager
    {
        IBuyerService BuyerService { get; }
        ISellerService SellerService { get; }
        IProductService ProductService { get; }
    }
}
