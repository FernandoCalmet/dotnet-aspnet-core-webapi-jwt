using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Contracts.Customers;
using WebAPI.Services;

namespace WebAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomersController(ICustomerService customerService) =>
        _customerService = customerService;

    [HttpGet]
    public async Task<IActionResult> GetCustomers(CancellationToken cancellationToken = default) =>
        Ok(await _customerService.GetCustomersAsync(cancellationToken));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomerById(Guid id, CancellationToken cancellationToken = default)
    {
        var customer = await _customerService.GetCustomerAsync(id, cancellationToken);
        return customer is null ? NotFound() : Ok(customer);
    }

    [HttpPost]
    public IActionResult CreateCustomer(CustomerRequest request)
    {
        _customerService.AddCustomer(request);
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCustomer(Guid id, CustomerRequest request)
    {
        _customerService.UpdateCustomer(id, request);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomer(Guid id, CancellationToken cancellationToken = default)
    {
        var customer = await _customerService.GetCustomerAsync(id, cancellationToken);
        if (customer is null)
            return NotFound();

        _customerService.DeleteCustomer(id);
        return NoContent();
    }
}