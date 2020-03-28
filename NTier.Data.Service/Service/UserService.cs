using NTier.Data.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.Data.Service
{
    public class UserService : Repository<User>
    {
        public UserService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
