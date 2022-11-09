using AutoMapper;
using NkwoTheApp.Domain.Models;
using NkwoTheApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.AppCore
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<BUYER, BuyerDto>()
                .ForCtorParam("FullAddress",
                opt => opt.MapFrom(x => string.Join(' ', x.User.Address.StreetNumber,
                x.User.Address.Street, x.User.Address.City, x.User.Address.Country)));
        }
    }
}
