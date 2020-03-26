using NTier.Core;

namespace NTier.Data.Model.System
{
    public class SystemAction : Table
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    }
}