using NkwoTheApp.Shared.ThirdPartyServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Shared.ThirdPartyServices.Services
{
    public class ReferenceGenerator: IReferenceGenerator
    {
        private readonly Random _random = new Random();
        public int GenerateRandomNumber()
        {
            return _random.Next(1000, 9999);
        }
        private string GenerateRandomString(int size)
        {
            var builder = new StringBuilder(size);
            char offset = 'A';
            const int lettersOffset = 26;
            for (var i = 0; i < size; i++)
            {
                var character = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(character);
            }
            return builder.ToString().ToUpper();
        }
        private string GenerateDate()
        {
            var date = DateTime.Now.Date;
            var year = long.Parse(date.ToString("yyyyMMdd"));
            return year.ToString();
        }
        public string GenerateReference()
        {
            var referenceBuilder = new StringBuilder();
            referenceBuilder.Append(GenerateDate());
            referenceBuilder.Append(GenerateRandomString(4));
            referenceBuilder.Append(GenerateRandomNumber());
            return referenceBuilder.ToString();
        }
    }
}
