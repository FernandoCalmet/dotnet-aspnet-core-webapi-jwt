namespace WebAPI.Services;

/// <summary>
/// Defines a service for user authentication and sign-in operations.
/// </summary>
public interface ILoginService
{
    /// <summary>
    /// Signs in a user asynchronously using their customer ID and email address.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer.</param>
    /// <param name="email">The email address of the customer.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the JWT token string if sign-in is successful.</returns>
    /// <exception cref="Exception">Thrown if the customer is not found or if the email does not match the customer's record.</exception>
    Task<string> SignInAsync(Guid customerId, string email);
}
