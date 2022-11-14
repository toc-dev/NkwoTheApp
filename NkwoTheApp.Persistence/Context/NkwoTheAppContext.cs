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
        public DbSet<USER> Users { get; set; }
        public DbSet<BUYER> Buyers { get; set; }
        public DbSet<SELLER> Sellers { get; set; }
        public DbSet<PRODUCT> Products { get; set; }
        public DbSet<CART> Carts { get; set; }
        public DbSet<PRICE_OFFER> PriceOffers { get; set; }
        public DbSet<PRODUCT_DETAIL> ProductsDetails { get; set; }
        public DbSet<ADDRESS> Addresses { get; set; }
    }
}
