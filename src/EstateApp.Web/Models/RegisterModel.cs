using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateApp.Web.Models {
    public class RegisterModel {

        [DisplayName ("FullName")]
        [Required]
        public string FullName { get; set; }

        [DisplayName ("Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }

        [DisplayName ("Confirm Password")]
        [Compare (nameof (Password))]
        public string ConfirmPassword { get; set; }

    }
}