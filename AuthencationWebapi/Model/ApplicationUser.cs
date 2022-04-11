using Microsoft.AspNetCore.Identity;

namespace AuthencationWebapi.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string fname { get; set; }
        public string lname { get; set; }
    }
}
