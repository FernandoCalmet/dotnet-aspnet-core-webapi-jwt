using WebAPI.Authentication;
using WebAPI.Entities.Customers;

namespace WebAPI.Services;

/// <summary>
/// Provides implementation for user authentication and sign-in operations.
/// </summary>
internal sealed class LoginService : ILoginService
{
    private readonly IJwtProvider _jwtProvider;
    private readonly ICustomerRepository _customerRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="LoginService"/> class.
    /// </summary>
    /// <param name="jwtProvider">The JWT provider for generating tokens.</param>
    /// <param name="customerRepository">The repository to access customer data.</param>
    public LoginService(IJwtProvider jwtProvider, ICustomerRepository customerRepository)
    {
        _jwtProvider = jwtProvider;
        _customerRepository = customerRepository;
    }

    /// <summary>
    /// Signs in a user asynchronously using their customer ID and email address.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer.</param>
    /// <param name="email">The email address of the customer.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the JWT token string if sign-in is successful.</returns>
    /// <exception cref="Exception">Thrown if the customer is not found or if the email does not match the customer's record.</exception>
    public async Task<string> SignInAsync(Guid customerId, string email)
    {
        var customer = await _customerRepository.GetCustomerByIdAsync(customerId);
        if (customer is null)
        {
            throw new Exception($"Customer with id: '{customerId}' was not found.");
        }

        if (customer.Email != email)
        {
            throw new Exception($"Customer with id: '{customerId}' has not email: '{email}'.");
        }

        return _jwtProvider.Generate(customerId, email);
    }
}