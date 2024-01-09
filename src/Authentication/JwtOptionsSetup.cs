using Microsoft.Extensions.Options;

namespace WebAPI.Authentication;

/// <summary>
/// Configures JWT options using the application's configuration settings.
/// </summary>
public class JwtOptionsSetup : IConfigureOptions<JwtOptions>
{
    private const string SectionName = "Jwt";
    private readonly IConfiguration _configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="JwtOptionsSetup"/> class.
    /// </summary>
    /// <param name="configuration">The application's configuration containing JWT settings.</param>
    public JwtOptionsSetup(IConfiguration configuration) =>
        _configuration = configuration;

    /// <summary>
    /// Configures the JWT options by binding them to the relevant configuration section.
    /// </summary>
    /// <param name="options">The JWT options to configure.</param>
    public void Configure(JwtOptions options) =>
        _configuration.GetSection(SectionName).Bind(options);
}
