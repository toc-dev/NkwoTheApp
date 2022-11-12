using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class USER: BASE_ENTITY
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OtherName { get; set; }
        [Required(ErrorMessage="A username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Invalid Email")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "A Phone number is required"), Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public PersonType PersonType { get; set; }
        public Gender? Gender { get; set; }
        [ForeignKey("AddressId")]
        public ADDRESS? Address { get; set; }
        public string? ImageURL { get; set; }
        public string? ReferralCode { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }


    }
}
