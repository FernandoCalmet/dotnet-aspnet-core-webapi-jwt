using WebAPI.Contracts.Customers;

namespace WebAPI.Services;

/// <summary>
/// Defines a service for managing customer data.
/// </summary>
public interface ICustomerService
{
    /// <summary>
    /// Retrieves a collection of all customers asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A token for canceling the operation, if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of customer responses.</returns>
    Task<IEnumerable<CustomerResponse>> GetCustomersAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a specific customer by their unique identifier asynchronously.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer.</param>
    /// <param name="cancellationToken">A token for canceling the operation, if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the customer response or null if not found.</returns>
    Task<CustomerResponse?> GetCustomerAsync(Guid customerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds a new customer to the repository.
    /// </summary>
    /// <param name="request">The customer request containing the data to add.</param>
    void AddCustomer(CustomerRequest request);

    /// <summary>
    /// Updates an existing customer's information based on their unique identifier.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer to update.</param>
    /// <param name="request">The customer request containing the updated data.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateCustomer(Guid customerId, CustomerRequest request);

    /// <summary>
    /// Deletes a customer from the repository based on their unique identifier.
    /// </summary>
    /// <param name="customerId">The unique identifier of the customer to delete.</param>
    void DeleteCustomer(Guid customerId);
}