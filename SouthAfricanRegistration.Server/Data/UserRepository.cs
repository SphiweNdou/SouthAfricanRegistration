using Microsoft.EntityFrameworkCore;
using Shared.Dtos;
using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Data
{
    internal class UserRepository: IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user != null) 
                return user;
            else 
                return default(User);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
