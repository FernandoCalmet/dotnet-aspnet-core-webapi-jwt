namespace WebAPI.Authentication;

/// <summary>
/// Defines a contract for a provider responsible for generating JSON Web Tokens (JWT).
/// </summary>
public interface IJwtProvider
{
    /// <summary>
    /// Generates a JWT for a specified customer.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer.</param>
    /// <param name="email">The email of the customer.</param>
    /// <returns>A JWT string.</returns>
    string Generate(Guid customerId, string email);
}
