using Microsoft.AspNetCore.Identity;

namespace Web_953503_Alshanikov.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
