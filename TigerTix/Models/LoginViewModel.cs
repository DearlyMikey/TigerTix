using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TigerTix.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Username or Email is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 20 or min 5 characters allowed.")]
        [DisplayName("Username or Email")]
        public string UserNameorEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Max 20 or min 8 characters allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
