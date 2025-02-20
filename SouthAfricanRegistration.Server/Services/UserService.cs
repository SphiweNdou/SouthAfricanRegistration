using SouthAfricanRegistration.Server.Data;
using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        public async Task AddUserAsync(string name, string IdNumber)
        {
           User user = new(name, IdNumber);
           await _userRepository.AddUserAsync(user);
        }
    }
}
