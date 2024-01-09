namespace WebAPI.Contracts.Customers;

public sealed record CustomerRequest(
    string FirstName,
    string LastName,
    string Contact,
    string Email);