using Bookbond.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using EFCore.NamingConventions;

namespace Bookbond.Api.Configurations.LayerConfigurations
{
    public static class DataAccessConfiguration
    {
        public static void Configure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("BookbondDbConnection")).UseSnakeCaseNamingConvention();
            });
        }
    }
}
