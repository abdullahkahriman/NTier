﻿using System.Collections.Generic;

namespace NTier.Data.Model.System.Authorization
{
    public class Authorize
    {
        public User User { get; set; }
        public List<SystemAction> AuthorizedActions { get; set; }
    }
}