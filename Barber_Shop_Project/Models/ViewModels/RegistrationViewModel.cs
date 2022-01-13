using System.ComponentModel.DataAnnotations;

namespace Barber_Shop_Project.Models.ViewModels
{
    public class RegistrationViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email not specified")]
        [Display(Name = "Your email")]
        [UIHint("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [Display(Name = "Enter password")]
        [UIHint("Password")]
        public string Password { get; set; }

        [Display(Name = "Confirm the entered password")]
        [UIHint("Password")]
        [Compare("Password", ErrorMessage = "Password entered incorrectly")]
        public string ConfirmPassword { get; set; }
    }
}