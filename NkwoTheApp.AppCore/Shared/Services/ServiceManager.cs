using AutoMapper;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Persistence.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Services
{
    public sealed class ServiceManager: IServiceManager
    {
        private readonly Lazy<IBuyerService> _buyerService;
        private readonly Lazy<ISellerService> _sellerService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _buyerService = new Lazy<IBuyerService>(() => new BuyerService(repositoryManager, logger, mapper));
            _sellerService = new Lazy<ISellerService>(() => new SellerService(repositoryManager, logger, mapper));
        }

        public IBuyerService BuyerService => _buyerService.Value;

        public ISellerService SellerService => _sellerService.Value;
    }
}
