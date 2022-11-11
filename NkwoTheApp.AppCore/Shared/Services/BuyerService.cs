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
    internal sealed class BuyerService: IBuyerService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BuyerService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<BuyerDto> GetAllBuyers(bool trackChanges)
        {
            var buyers = _repositoryManager.Buyer.GetAllBuyers(trackChanges);
            var buyersDto = buyers.Select(b => new BuyerDto
            {
                Username = b.User.Username,
                RegistrationStatus = Enum.GetName(typeof(RegistrationStatus), b.RegistrationStatus),
                EmailAddress = b.User.EmailAddress,
                PhoneNumber = b.User.PhoneNumber,
                FullAddress = b.User.Address.StreetNumber + " " + b.User.Address.Street + ", "
                + b.User.Address.City + ". " + b.User.Address.Country
            }).ToList();
            return buyersDto;
        }

        public BuyerDto GetBuyer(Guid buyerId, bool trackChanges)
        {
            var buyer = _repositoryManager.Buyer.GetBuyer(buyerId, trackChanges);
            if (buyer is null)
                throw new BuyerNotFoundException(buyerId);
            var buyerDto = new BuyerDto
            {
                Username = buyer.User.Username,
                RegistrationStatus = Enum.GetName(typeof(RegistrationStatus), buyer.RegistrationStatus),
                EmailAddress = buyer.User.EmailAddress,
                PhoneNumber = buyer.User.PhoneNumber,
                FullAddress = buyer.User.Address.StreetNumber + " " + buyer.User.Address.Street + " street, "
                + buyer.User.Address.City + ". " + buyer.User.Address.Country
            };

            return buyerDto;
        }
    }
}
