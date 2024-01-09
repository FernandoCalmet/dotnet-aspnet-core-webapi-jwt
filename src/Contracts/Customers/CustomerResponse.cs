namespace WebAPI.Contracts.Customers;

public sealed class CustomerResponse
{
    public string FirstName { get; init; } = string.Empty;

    public string LastName { get; init; } = string.Empty;

    public string Contact { get; init; } = string.Empty;

    public string Email { get; init; } = string.Empty;
}