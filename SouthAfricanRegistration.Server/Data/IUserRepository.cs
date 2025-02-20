using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Data
{
    internal interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task AddUserAsync(User user);
    }
}
