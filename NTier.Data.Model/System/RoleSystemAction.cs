using NTier.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTier.Data.Model.System
{
    public class RoleSystemAction : Table
    {
        public long RoleID { get; set; }
        public long SystemActionID { get; set; }

        [ForeignKey(nameof(RoleID))]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(SystemActionID))]
        public virtual SystemAction SystemAction { get; set; }
    }
}