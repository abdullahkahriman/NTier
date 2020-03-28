using Microsoft.Extensions.DependencyInjection;
using NTier.Data.Model.Entity;
using NTier.Data.Model.System;
using NTier.Data.Service.Interface;

namespace NTier.Data.Service
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddDbContextService();
            services.AddTransient<IRepository<Book>, BookService>();
            services.AddTransient<IRepository<User>, UserService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            return services;
        }
    }
}