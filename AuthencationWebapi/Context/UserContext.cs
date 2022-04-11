using AuthencationWebapi.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthencationWebapi.Context
{
    public class UserContext:IdentityDbContext<ApplicationUser>
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<tbluser>Tblusers { get; set; } 
    }
}
