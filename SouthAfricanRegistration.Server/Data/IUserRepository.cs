using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Data
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task AddUserAsync(User user);
    }
}
