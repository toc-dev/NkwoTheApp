﻿using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Domain.Models
{
    public class REVIEW
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public StarReview StarReview { get; set; }
        public string? Comment { get; set; }
        [ForeignKey("ProductId")]
        public PRODUCT? Product { get; set; }
        [ForeignKey("UserId")]
        public USER? Reviewer { get; set; }
    }
}
