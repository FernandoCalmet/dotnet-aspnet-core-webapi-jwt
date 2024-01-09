using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebAPI.Authentication;

/// <summary>
/// Provides functionality to generate JSON Web Tokens (JWT) for authentication purposes.
/// </summary>
internal sealed class JwtProvider : IJwtProvider
{
    private readonly JwtOptions _options;

    /// <summary>
    /// Initializes a new instance of the <see cref="JwtProvider"/> class.
    /// </summary>
    /// <param name="options">Configuration options for JWT generation.</param>
    public JwtProvider(IOptions<JwtOptions> options) =>
        _options = options.Value;

    /// <summary>
    /// Generates a JWT for a specified customer.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer.</param>
    /// <param name="email">The email of the customer.</param>
    /// <returns>A JWT string.</returns>
    /// <remarks>
    /// The token includes claims for the customer's ID and email. It is signed with a secret key and valid for a limited time.
    /// </remarks>
    public string Generate(Guid customerId, string email)
    {
        var claims = new Claim[]
        {
            new(JwtRegisteredClaimNames.Sub, customerId.ToString()),
            new(JwtRegisteredClaimNames.Email, email)
        };

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_options.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            _options.Issuer,
            _options.Audience,
            claims,
            null,
            DateTime.UtcNow.AddHours(1),
            signingCredentials);

        var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }
}