using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using NkwoTheApp.Shared.DTOs;
using System.Text;

namespace NkwoTheApp.Formatters
{
    public class CSVOutputFormatter: TextOutputFormatter
    {
        public CSVOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        protected override bool CanWriteType(Type? type)
        {
            if (typeof(BuyerDto).IsAssignableFrom(type) || typeof(IEnumerable<BuyerDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<BuyerDto>)
            {
                foreach (var buyer in (IEnumerable<BuyerDto>)context.Object)
                {
                    FormatCsv(buffer, buyer);
                }
            }
            else
            {
                FormatCsv(buffer, (BuyerDto)context.Object);
            }
            await response.WriteAsync(buffer.ToString());
        }

        private static void FormatCsv(StringBuilder buffer, BuyerDto buyer)
        {
            buffer.AppendLine($"{buyer.Username},\"{buyer.EmailAddress}\"{buyer.FullAddress}\"");
        }
    }
}
