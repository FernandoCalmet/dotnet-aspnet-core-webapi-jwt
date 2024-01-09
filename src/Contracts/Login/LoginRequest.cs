namespace WebAPI.Contracts.Login;

public sealed record LoginRequest(Guid UserId, string Email);