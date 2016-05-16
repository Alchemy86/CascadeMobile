using System.ComponentModel.DataAnnotations;

namespace Mobile.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Pin")]
        [DataType(DataType.Password)]
        public bool PinNumber { get; set; }
    }
}
