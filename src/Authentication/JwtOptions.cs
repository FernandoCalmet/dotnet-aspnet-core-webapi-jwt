namespace WebAPI.Authentication;

/// <summary>
/// Represents the configuration settings for JWT.
/// </summary>
public sealed class JwtOptions
{
    /// <summary>
    /// Gets or initializes the issuer of the JWT.
    /// </summary>
    public string Issuer { get; init; } = string.Empty;

    /// <summary>
    /// Gets or initializes the intended audience of the JWT.
    /// </summary>
    public string Audience { get; init; } = string.Empty;

    /// <summary>
    /// Gets or initializes the secret key used for signing the JWT.
    /// </summary>
    public string SecretKey { get; init; } = string.Empty;
}
