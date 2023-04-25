using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entities;
using Services;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IusersServices _services;
        public UserController(IusersServices services)
        {
            _services = services;
        }

        [HttpPost("login")]
        public async Task<User> loginAsync([FromBody] User newUser)
        {
            return await _services.loginAsync(newUser);
        }

        [HttpPost("register")]
        public async Task<User> registerAsync([FromBody] User newUser)
        {
            
            return await _services.registerAsync(newUser);
        }
    [HttpPost("password")]

    public int checkPassword([FromBody] User fakeUserWithPassword)
    {
        return _services.passwordRate(fakeUserWithPassword.password);
    }

}
