using Microsoft.EntityFrameworkCore;
using NTier.Data.Context.Context;
using NTier.Data.Model.System;
using NTier.Data.Model.System.Authentication;
using NTier.Data.Model.System.Authorization;
using NTier.Data.Service.Interface;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using NTier.Core;

namespace NTier.Data.Service
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly NTierDBContext _context;
        public AuthorizationService(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<NTierDBContext>();
        }

        public Authorize Get(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                Token modelToken = token.FromRijndael<Token>();
                if (modelToken.ExpireDate > DateTime.Now)
                {
                    User user = _context.User.FirstOrDefault(c => c.ID.Equals(modelToken.UserID));
                    if (user != null)
                    {
                        return new Authorize()
                        {
                            User = user,
                            AuthorizedActions = _context.RoleSystemAction
                            .Include(c => c.SystemAction)
                            .Where(c => c.RoleID.Equals(user.RoleID))
                            .Select(c => c.SystemAction).ToList()
                        };
                    }
                }
            }

            return null;
        }
    }
}
