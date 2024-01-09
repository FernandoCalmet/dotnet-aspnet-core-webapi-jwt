using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Contracts.Login;
using WebAPI.Services;

namespace WebAPI.Controllers;

[AllowAnonymous]
[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly ILoginService _loginService;

    public AuthenticationController(ILoginService loginService) =>
        _loginService = loginService;

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var token = await _loginService.SignInAsync(request.UserId, request.Email);
        return Ok(new LoginResponse { Token = token });
    }
}