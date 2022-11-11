using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record BuyerDto
    {
        public string Username { get; init; }
        public string RegistrationStatus { get; init; }
        public string EmailAddress { get; init; }
        public string PhoneNumber { get; init; }
        public string FullAddress { get; init; }
    }   

}
