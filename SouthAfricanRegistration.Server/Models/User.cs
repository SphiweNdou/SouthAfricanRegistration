namespace SouthAfricanRegistration.Server.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string SouthAfricanIdNumber { get; private set; }
        public string Name { get; set; }
        public int Age { get; private set; }

        public User() {}

        public User(string name, string IdNumber, int age) 
        {
            Name = name;
            SouthAfricanIdNumber = IdNumber;
            Age = age;
        }
    }
}
