using System.ComponentModel.DataAnnotations;

namespace CoreFirst.Models
{
    public class SignupUser
    {
        [Required(ErrorMessage = "Username is required")]
        [EmailAddress]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [Display(Name="Confirm Pssword")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [Display(Name = "Confirm Pssword")]
        [Compare("Password",ErrorMessage="Password and confirm Message doesnot match")]
        public string ConfirmPassword { get; set; }
        
    }
}
