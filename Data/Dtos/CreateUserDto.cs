using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace AuthCore.Data.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
