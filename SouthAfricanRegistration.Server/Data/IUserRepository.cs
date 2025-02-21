using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Data
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task AddUserAsync(User user);
        Task<User> GetUserAsync(int id);
        Task DeleteUserAsync(User user);
        Task UpdateUserAsync(User user);
    }
}
