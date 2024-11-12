using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TigerTix.Entities
{
	// Ensure that user's email and username are unique 
	[Index(nameof(Email), IsUnique = true)]
	[Index(nameof(UserName), IsUnique = true)]
	public class EventHandler
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Organization name is required.")]
		[MaxLength(50, ErrorMessage = "Max 50 characters allowed.")]
		public required string OrganizationName { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[MaxLength(100, ErrorMessage = "Max 100 characters allowed.")]
		public required string Email { get; set; }

		[Required(ErrorMessage = "Username is required.")]
		[MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
		public required string UserName { get; set; }

		[Required(ErrorMessage = "Password is required.")]
		[MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
		public required string Password { get; set; }
	}
}