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
           
            int age = CalculateUserAge(IdNumber);
            User user = new(name, IdNumber, age);
            await _userRepository.AddUserAsync(user);
        }

        private static int CalculateUserAge(string idNumber)
        {
            if (idNumber.Length != 13 || !long.TryParse(idNumber, out _))
                return 0;

            string birthYear = idNumber[..2];
            string birthMonth = idNumber[2..4];
            string birthDay = idNumber[4..6];

            int year = int.Parse(birthYear) > DateTime.Now.Year - 2000 ? 1900 + int.Parse(birthYear) : 2000 + int.Parse(birthYear);
            DateTime birthDate = new DateTime(year, int.Parse(birthMonth), int.Parse(birthDay));
            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate > DateTime.Today.AddYears(-age))
                age--;

            return age;
        }
    }
}
