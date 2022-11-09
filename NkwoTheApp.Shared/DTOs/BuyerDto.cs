using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record BuyerDto(string UserName,
        RegistrationStatus RegistrationStatus,
        string EmailAddress, string PhoneNuumber,
        string FullAddress);

}
