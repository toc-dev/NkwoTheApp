using Microsoft.EntityFrameworkCore;
using NkwoTheApp.AppCore.Shared.Interfaces;
using NkwoTheApp.AppCore.Shared.Services;
using NkwoTheApp.Formatters;
using NkwoTheApp.Persistence.Context;
using NkwoTheApp.Persistence.Repository.Interfaces;
using NkwoTheApp.Persistence.Repository.Services;
using NkwoTheApp.Shared.ThirdPartyServices.Interfaces;
using NkwoTheApp.Shared.ThirdPartyServices.Services;

namespace NkwoTheApp.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)=>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services)=>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services)=>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<NkwoTheAppContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureReferenceGenerator(this IServiceCollection services)=>
            services.AddTransient<IReferenceGenerator, ReferenceGenerator>();

        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config => config.OutputFormatters.Add(new CSVOutputFormatter()));
    }
}
