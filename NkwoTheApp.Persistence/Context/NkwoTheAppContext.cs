using Microsoft.EntityFrameworkCore;
using NkwoTheApp.Domain.Models;
using NkwoTheApp.Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Context
{
    public class NkwoTheAppContext: DbContext
    {
        public NkwoTheAppContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BuyerConfiguration());
            modelBuilder.ApplyConfiguration(new SellerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            //other configurations when ready
        }
        public DbSet<USER> User { get; set; }
        public DbSet<BUYER> Buyer { get; set; }
        public DbSet<SELLER> Seller { get; set; }
        public DbSet<PRODUCT> Product { get; set; }
        public DbSet<CART> Cart { get; set; }
        public DbSet<PRICE_OFFER> PriceOffer { get; set; }
        public DbSet<PRODUCT_DETAILS> StoreProduct { get; set; }
        public DbSet<ADDRESS> Address { get; set; }
    }
}
