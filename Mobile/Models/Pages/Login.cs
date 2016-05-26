using System;
using System.ComponentModel.DataAnnotations;

namespace Mobile.Models.Pages
{
    public class Login : BaseModel
    {
        /// <summary>
        /// Session Token
        /// </summary>
        public Guid SessionToken { get; set; }

        /// <summary>
        /// Store the session object as a string
        /// </summary>
        public string CascadeSessionStateString { get; set; }

        /// <summary>
        /// Is hosted
        /// </summary>
        public bool IsHosted { get; set; }

        public bool PinIsAllowed { get; set; }

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
