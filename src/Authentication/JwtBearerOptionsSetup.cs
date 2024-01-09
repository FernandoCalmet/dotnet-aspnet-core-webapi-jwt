using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebAPI.Authentication;

/// <summary>
/// Configures JWT Bearer options post-creation with JWT-specific settings.
/// </summary>
public class JwtBearerOptionsSetup : IPostConfigureOptions<JwtBearerOptions>
{
    private readonly JwtOptions _jwtOptions;

    /// <summary>
    /// Initializes a new instance of the <see cref="JwtBearerOptionsSetup"/> class.
    /// </summary>
    /// <param name="jwtOptions">The JWT options containing issuer, audience, and secret key details.</param>
    public JwtBearerOptionsSetup(IOptions<JwtOptions> jwtOptions) =>
        _jwtOptions = jwtOptions.Value;

    /// <summary>
    /// Post-configures the specified JWT Bearer options.
    /// </summary>
    /// <param name="name">The name of the options instance being configured.</param>
    /// <param name="options">The JWT Bearer options to configure.</param>
    /// <remarks>
    /// Sets the validation parameters for the issuer, audience, and issuer signing key based on provided JWT options.
    /// </remarks>
    public void PostConfigure(string? name, JwtBearerOptions options)
    {
        options.TokenValidationParameters.ValidIssuer = _jwtOptions.Issuer;
        options.TokenValidationParameters.ValidAudience = _jwtOptions.Audience;
        options.TokenValidationParameters.IssuerSigningKey =
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));
    }
}