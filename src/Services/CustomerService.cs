using WebAPI.Contracts.Customers;
using WebAPI.Entities.Customers;

namespace WebAPI.Services;

/// <summary>
/// Provides implementation of the <see cref="ICustomerService"/>, managing customer data.
/// </summary>
internal sealed class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerService"/> class.
    /// </summary>
    /// <param name="customerRepository">The customer repository to manage customer data.</param>
    public CustomerService(ICustomerRepository customerRepository) =>
        _customerRepository = customerRepository;

    /// <summary>
    /// Retrieves a collection of all customers asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A token for canceling the operation, if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of customer responses.</returns>
    public async Task<IEnumerable<CustomerResponse>> GetCustomersAsync(CancellationToken cancellationToken = default)
    {
        var customers = await _customerRepository.GetCustomersAsync(cancellationToken);

        return customers.Select(customer => new CustomerResponse
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Contact = customer.Contact,
            Email = customer.Email
        });
    }

    /// <summary>
    /// Retrieves a specific customer by their unique identifier asynchronously.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer.</param>
    /// <param name="cancellationToken">A token for canceling the operation, if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the customer response or null if not found.</returns>
    public async Task<CustomerResponse?> GetCustomerAsync(Guid customerId, CancellationToken cancellationToken = default)
    {
        var customer = await _customerRepository.GetCustomerByIdAsync(customerId, cancellationToken);

        return customer is null ? null : new CustomerResponse
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Contact = customer.Contact,
            Email = customer.Email
        };
    }

    /// <summary>
    /// Adds a new customer to the repository.
    /// </summary>
    /// <param name="request">The customer request containing the data to add.</param>
    public void AddCustomer(CustomerRequest request)
    {
        var customer = new Customer
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Contact = request.Contact,
            Email = request.Email
        };

        _customerRepository.AddCustomer(customer);
    }

    /// <summary>
    /// Updates an existing customer's information based on their unique identifier.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer to update.</param>
    /// <param name="request">The customer request containing the updated data.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task UpdateCustomer(Guid customerId, CustomerRequest request)
    {
        var customer = await _customerRepository.GetCustomerByIdAsync(customerId);

        if (customer is null)
            throw new InvalidOperationException("Customer not found.");

        customer.FirstName = request.FirstName;
        customer.LastName = request.LastName;
        customer.Contact = request.Contact;
        customer.Email = request.Email;

        _customerRepository.UpdateCustomer(customer);
    }

    /// <summary>
    /// Deletes a customer from the repository based on their unique identifier.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer to delete.</param>
    public void DeleteCustomer(Guid customerId) => _customerRepository.DeleteCustomer(customerId);
}