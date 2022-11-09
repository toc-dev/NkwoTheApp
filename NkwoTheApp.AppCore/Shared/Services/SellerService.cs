using AutoMapper;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.Domain.Exceptions;
using NkwoTheApp.Persistence.Repository.Interfaces;
using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore.Shared.Services
{
    internal sealed class SellerService: ISellerService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SellerService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<SellerDto> GetAllSellers(bool trackChanges)
        {
            var sellers = _repositoryManager.Seller.GetAllSellers(trackChanges);
            var sellersDto = sellers.Select(s=>new SellerDto(s.User.Username,
                s.User.RegistrationStatus, s.User.EmailAddress,
                s.User.PhoneNumber, s.User.Address.StreetNumber + " " + s.User.Address.Street + " street, "
                + s.User.Address.City + " " +s.User.Address.Country)).ToList();

            return sellersDto;

        }

        public SellerDto GetSeller(Guid sellerId, bool trackChanges)
        {
            var seller = _repositoryManager.Seller.GetSeller(sellerId, trackChanges);
            if (seller is null)
                throw new SellerNotFoundException(sellerId);
            var sellerDto = new SellerDto(seller.User.Username,
                seller.User.RegistrationStatus, seller.User.EmailAddress,
                seller.User.PhoneNumber, seller.User.Address.StreetNumber + " " + seller.User.Address.Street + " street, "
                + seller.User.Address.City + " " + seller.User.Address.Country);

            return sellerDto;
        }
    }
}
