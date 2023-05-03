using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class SignInViewModel
    {
        [Display(Name = "E-mail address")]
        [Required(ErrorMessage = "E-mail address is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; }
    }
}
