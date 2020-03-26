using NTier.Data.Context.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using System.IO;

namespace NTier.Data.Service
{
    public static class DbContextService
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            ServiceProvider provider = services.BuildServiceProvider();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NTier.API"))
                .AddJsonFile("appsettings.json")
                .Build();
            services.AddDbContext<NTierDBContext>(x => x.UseSqlServer(configuration.GetConnectionString("DB")));
            return services;
        }
    }
}
