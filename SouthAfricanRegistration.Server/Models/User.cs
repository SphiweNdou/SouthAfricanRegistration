namespace SouthAfricanRegistration.Server.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string SouthAfricanIdNumber { get; private set; }
        public string Name { get; set; }
        public int Age { get; private set; }

        public User() {}

        public User(string name, string IdNumber) 
        {
            Name = name;
            SouthAfricanIdNumber = IdNumber;
            Age = CalculateUserAge(IdNumber);
        }

        private static int CalculateUserAge(string idNumber)
        {
            if( idNumber.Length != 13 || !long.TryParse(idNumber, out _) )
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
