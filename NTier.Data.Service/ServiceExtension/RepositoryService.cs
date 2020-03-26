using Microsoft.Extensions.DependencyInjection;
using NTier.Data.Model.Entity;

namespace NTier.Data.Service
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddDbContextService();
            services.AddTransient<IRepository<Book>, BookService>();
            //services.AddTransient<IRepository<Comment>, CommentService>();
            //services.AddTransient<IRepository<Role>, RoleService>();
            //services.AddTransient<IRepository<RoleSystemAction>, RoleSystemActionService>();
            //services.AddTransient<IRepository<SystemAction>, SystemActionService>();
            //services.AddTransient<IRepository<User>, UserService>();
            //services.AddTransient<IAuthorizationService, AuthorizationService>();
            return services;
        }
    }
}