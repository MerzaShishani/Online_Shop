using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Dtos.User;
using Online_Shop.Models;
using Online_Shop.Services.AuthService;

namespace Online_Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService) {
            _authService=authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Response<string>>> Login(UserLoginDto loginDto) {
            var response = await _authService.Login(loginDto);
            if (response.Success)
                return Ok(response);
            return Unauthorized(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult<Response<int>>> Register(UserRegistrationDto registrationDto) {
            var response = await _authService.Register(registrationDto);
            if(response.Success)
                return Ok(response);
            return Conflict(response);
        }
    }   
}
