using Microsoft.AspNetCore.Identity;

namespace ShatibyApi.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
