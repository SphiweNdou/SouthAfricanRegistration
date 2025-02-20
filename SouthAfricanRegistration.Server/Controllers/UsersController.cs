using SouthAfricanRegistration.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace SouthAfricanRegistration.Server.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] UserDto userDto)
        {
            if (userDto == null || string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.SouthAfricanID))
            {
                return BadRequest("Invalid user data.");
            }

            
            await _userService.AddUserAsync(userDto.Name, userDto.SouthAfricanID);
            return Ok(new { Message = "User added successfully!" });
        }
    }
}
