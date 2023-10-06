using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<SQL_DbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IDbContext>(provider =>
                provider.GetService<SQL_DbContext>());
            return services;
        }
    }
}
