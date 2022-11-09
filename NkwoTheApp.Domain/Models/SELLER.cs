using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class SELLER: BASE_ENTITY
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }
        [ForeignKey("UserId")]
        public virtual USER? User { get; set; }
    }
}
