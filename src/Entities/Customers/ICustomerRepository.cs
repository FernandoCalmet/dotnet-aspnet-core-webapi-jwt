namespace WebAPI.Entities.Customers;

/// <summary>
/// Defines the contract for a repository that manages customer data.
/// </summary>
public interface ICustomerRepository
{
    /// <summary>
    /// Retrieves all customers asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an enumerable of all customers.</returns>
    Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a specific customer by their unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the customer.</param>
    /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the customer if found, otherwise null.</returns>
    Task<Customer?> GetCustomerByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds a new customer to the repository.
    /// </summary>
    /// <param name="customer">The customer entity to add.</param>
    void AddCustomer(Customer customer);

    /// <summary>
    /// Updates an existing customer in the repository.
    /// </summary>
    /// <param name="customer">The customer entity with updated information.</param>
    void UpdateCustomer(Customer customer);

    /// <summary>
    /// Deletes a customer from the repository based on their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the customer to delete.</param>
    void DeleteCustomer(Guid id);
}