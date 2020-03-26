using NTier.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NTier.Data.Model.System
{
    public class User : Table
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public long RoleID { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(RoleID))]
        public Role Role { get; set; }
    }
}