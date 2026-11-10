
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AuthCore.Models;
using Microsoft.EntityFrameworkCore;
namespace AuthCore.Data
{
    public class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext(DbContextOptions<UserDbContext> opts) : base(opts)
        {
            
        }
    }
}
