using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NTier.Data.Context.Context;
using System.IO;

namespace NTier.Data.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NTierDBContext>
    {
        public NTierDBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NTierDBContext>();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NTier.API"))
                .AddJsonFile("appsettings.json")
                .Build();
            builder.UseSqlServer(configuration.GetConnectionString("DB"));
            return new NTierDBContext(builder.Options);
        }
    }
}