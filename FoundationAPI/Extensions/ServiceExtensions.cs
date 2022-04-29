using Foundation.Core.Logger;
using Foundation.Core.Repository;
using Foundation.Data.Data;
using Foundation.Data.Repositories;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Service;
using Service.Contracts;

namespace FoundationAPI.Extensions;
public static class ServiceExtensions
{

    public static void ConfigureCors(this IServiceCollection services) =>
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

    public static void ConfigureUnitOfWork(this IServiceCollection services) =>
        services.AddScoped<IUoW, UoW>();

    public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();

    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
}

