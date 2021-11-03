using JWT.Authentication.WebAPI.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace JWT.Authentication.WebAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
