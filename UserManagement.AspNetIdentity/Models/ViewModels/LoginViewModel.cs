using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.AspNetIdentity.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }




        [Required(ErrorMessage = "Password is required")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string Password { get; set; }




        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
