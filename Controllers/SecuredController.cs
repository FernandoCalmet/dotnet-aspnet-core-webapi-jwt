using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Authentication.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecuredController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecuredData()
        {
            return Ok("This Secured Data is available only for Authenticated Users.");
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult PostSecuredData()
        {
            return Ok("This Secured Data is available only for Administrators.");
        }
    }
}
