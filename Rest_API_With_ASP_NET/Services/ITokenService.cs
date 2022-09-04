using System.Collections.Generic;
using System.Security.Claims;

namespace Rest_API_With_ASP_NET.Services.Implementations
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
