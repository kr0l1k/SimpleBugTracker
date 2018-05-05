using System.ComponentModel.DataAnnotations;

namespace SimpleBugTracker.ViewModel
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Email can not be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Wrong password")]
        public string ConfirmPassword { get; set; }
    }
}
