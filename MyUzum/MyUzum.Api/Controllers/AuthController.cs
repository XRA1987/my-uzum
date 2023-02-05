using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyUzum.Api.Models;
using MyUzum.Infrastructure.Abstractions;

namespace MyUzum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServise _authServise;
        public AuthController(IAuthServise authServise)
        {
            _authServise = authServise;
        }
        [HttpPost("Login")]

        public async Task<IActionResult> LoginAsync(LoginRequest loginRequest)
        {
            var token = await _authServise.LoginAsync(loginRequest.UserName, loginRequest.Password);
            return Ok(token);
        }
    }
}
