using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record SellerDto(
        string UserName,
        RegistrationStatus RegistrationStatus,
        string EmailAddress,
        string PhoneNumber,
        string FullAddress
        );
}
