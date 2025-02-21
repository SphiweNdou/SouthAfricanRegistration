using Shared.Dtos;
using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersAsync();
        Task<bool>  AddUserAsync(string name, string IdNumber);
        Task<bool> UpdateUserAsync(int id, string name, string idNumber);
        Task<bool> DeleteUserAsync(int id);
    }
}
