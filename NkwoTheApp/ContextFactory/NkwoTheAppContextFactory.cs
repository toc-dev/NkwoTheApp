using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NkwoTheApp.Persistence.Context;

namespace NkwoTheApp.ContextFactory
{
    public class NkwoTheAppContextFactory : IDesignTimeDbContextFactory<NkwoTheAppContext>
    {
        public NkwoTheAppContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<NkwoTheAppContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b=>b.MigrationsAssembly("NkwoTheApp"));
            return new NkwoTheAppContext(builder.Options);
        }
    }
}
