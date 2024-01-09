using Microsoft.EntityFrameworkCore;
using WebAPI.Entities.Customers;

namespace WebAPI.Data.Repositories;

/// <summary>
/// Provides an implementation of the <see cref="ICustomerRepository"/> for managing customer data.
/// </summary>
public class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
    /// </summary>
    /// <param name="context">The application database context to be used in the repository.</param>
    public CustomerRepository(ApplicationDbContext context) => _context = context;

    /// <summary>
    /// Retrieves all customers asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an enumerable of all customers.</returns>
    public async Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken cancellationToken = default) =>
        await _context.Set<Customer>().ToListAsync(cancellationToken);

    /// <summary>
    /// Retrieves a specific customer by their unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the customer.</param>
    /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the customer if found, otherwise null.</returns>
    public async Task<Customer?> GetCustomerByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await _context.Set<Customer>()
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

    /// <summary>
    /// Adds a new customer to the repository.
    /// </summary>
    /// <param name="customer">The customer entity to add.</param>
    public void AddCustomer(Customer customer) =>
        _context.Set<Customer>().Add(customer);

    /// <summary>
    /// Updates an existing customer in the repository.
    /// </summary>
    /// <param name="customer">The customer entity with updated information.</param>
    public void UpdateCustomer(Customer customer) =>
        _context.Set<Customer>().Update(customer);

    /// <summary>
    /// Deletes a customer from the repository based on their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the customer to delete.</param>
    public void DeleteCustomer(Guid id) =>
        _context.Set<Customer>().Remove(new Customer { Id = id });
}