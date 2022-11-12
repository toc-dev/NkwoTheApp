using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record BuyerCreationDto(string? FirstName, string? LastName,
        string? OtherName, string Username, string EmailAddress, string PhoneNumber, Gender? Gender,
        string? Country, string Region, string? City, string? Street, string? StreetNumber,
        DateTime? DateOfBirth, string? ReferalCode, string? ImageUrl);
}
