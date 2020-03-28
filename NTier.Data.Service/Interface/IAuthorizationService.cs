using NTier.Data.Model.System.Authorization;

namespace NTier.Data.Service.Interface
{
    public interface IAuthorizationService
    {
        Authorize Get(string token);
    }
}