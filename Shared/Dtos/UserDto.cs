using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Please input your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input your ID number")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "ID number must be exactly 13 digits")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "ID number can only contain digits")]
        public string SouthAfricanID { get; set; }
    }
}
