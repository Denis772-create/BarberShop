using System.ComponentModel.DataAnnotations;

namespace Barber_Shop_Project.Models.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            RememberMe = true;
        }

        [Required(ErrorMessage = "Email not specified")]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [UIHint("Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}