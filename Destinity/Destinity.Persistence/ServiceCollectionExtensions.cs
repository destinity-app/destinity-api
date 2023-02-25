using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Destinity.Persistence; 

public static class ServiceCollectionExtensions {
    public static void AddApplicationDbContext(this IServiceCollection serviceExtensions, IConfiguration configuration,
        IWebHostEnvironment env) {
        string connectionString;
        if (env.IsProduction()) {
            connectionString = new HerokuDbConnector.HerokuDbConnector().Build();
        }
        else {
            connectionString = configuration.GetConnectionString("Default") ?? throw new NullReferenceException("Default connection string not found.");
        }
        serviceExtensions.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
    }
}
