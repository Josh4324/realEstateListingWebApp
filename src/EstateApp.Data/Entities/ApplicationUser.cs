using Microsoft.AspNetCore.Identity;

namespace EstateApp.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname {get; set;}

          public string Password {get; set;}

            public string ConfirmPassword {get; set;}
    }
}