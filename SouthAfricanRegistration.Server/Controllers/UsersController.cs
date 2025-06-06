﻿using SouthAfricanRegistration.Server.Services;
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
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (userDto == null || string.IsNullOrWhiteSpace(userDto.Name) || string.IsNullOrWhiteSpace(userDto.SouthAfricanID))
                return BadRequest("Invalid user data.");
            
            bool userAdded = await _userService.AddUserAsync(userDto.Name, userDto.SouthAfricanID);

            if (userAdded)
                return Ok(new { Message = "User added successfully" });
            else 
                return BadRequest("Invalid user data.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserDto userDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updated = await _userService.UpdateUserAsync(id, userDto.Name, userDto.SouthAfricanID);
            if (!updated) return NotFound("User not found or invalid User");

            return Ok(new { Message = "User updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deleted = await _userService.DeleteUserAsync(id);
            if (!deleted) return NotFound("User not found.");

            return Ok(new { Message = "User deleted successfully" });
        }
    }
}
