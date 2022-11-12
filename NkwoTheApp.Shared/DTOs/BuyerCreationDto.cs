using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{//a bit of a dilemma of if this would work better as a user creation dto which could then be upgraded to a buyer or a seller
    public record BuyerCreationDto(string? FirstName, string? LastName,
        string? OtherName, string Username, string EmailAddress, string PhoneNumber, Gender? Gender,
        string? Country, string Region, string? City, string? Street, string? StreetNumber,
        DateTime? DateOfBirth, string? ReferalCode, string? ImageUrl);
}
