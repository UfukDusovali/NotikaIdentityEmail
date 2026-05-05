using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;

namespace NotikaIdentityEmail.Entities
{
    public class AppUser:IdentityUser
    {
        public string Name  { get; set; }
        public string Surname  { get; set; }
        public string? ImageUrl { get; set; }
        public string? City { get; set; }
    }
}
