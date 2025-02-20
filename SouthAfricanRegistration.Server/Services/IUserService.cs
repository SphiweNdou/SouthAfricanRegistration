using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task AddUserAsync(string name, string IdNumber);
    }
}
