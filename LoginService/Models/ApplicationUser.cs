using Microsoft.AspNetCore.Identity;

namespace LoginService.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int MyProperty { get; set; }
    }
}
