using System;

namespace NTier.Data.Model.System.Authentication
{
    public class Token
    {
        public long UserID { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}