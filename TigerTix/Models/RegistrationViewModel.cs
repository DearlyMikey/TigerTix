using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TigerTix.Models
{
	public class RegistrationViewModel
	{

		[Required(ErrorMessage = "First name is required.")]
		[MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
		public required string FirstName { get; set; }

		[Required(ErrorMessage = "Last name is required.")]
		[MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
		public required string LastName { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[MaxLength(100, ErrorMessage = "Max 100 characters allowed.")]
		public required string Email { get; set; }

		[Required(ErrorMessage = "Username is required.")]
		[MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
		public required string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
		[MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
		public required string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password does not match")]
        [MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
        public required string ConfirmPassword { get; set; }

    }
}
