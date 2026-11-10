using Microsoft.AspNetCore.Identity;
namespace AuthCore.Models
{
    public class User : IdentityUser
    {
        public DateTime Birthday { get; set; }

        public User() : base()
        {
            
        }
    }
}
