using Contracts;
using LoggerService;
using Repository;

namespace CompanyEmployees.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => 
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()));
        }

        public static void ConfigureIISIdentity(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
