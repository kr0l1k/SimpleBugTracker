using System.ComponentModel.DataAnnotations;

namespace SimpleBugTracker.ViewModel
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email can not be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
