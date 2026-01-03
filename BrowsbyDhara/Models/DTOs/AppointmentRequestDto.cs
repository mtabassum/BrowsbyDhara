using System.ComponentModel.DataAnnotations;

namespace BrowsbyDhara.Models.DTOs
{
    public class AppointmentRequestDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "The e-mail address entered is invalid.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date is required")]
        public DateTime DateRequested { get; set; } = DateTime.Today;

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? PhoneNumber { get; set; }
        public string? Reason { get; set; }
        public string? Notes { get; set; }
    }
}
