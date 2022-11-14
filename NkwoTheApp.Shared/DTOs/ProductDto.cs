﻿using NkwoTheApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.DTOs
{
    public record ProductDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string ProductCategory { get; init; }
    }
}
