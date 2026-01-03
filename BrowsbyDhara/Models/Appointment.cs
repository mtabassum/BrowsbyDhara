namespace BrowsbyDhara.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }

        public DateTime RequestedDate { get; set; }
        public string ServiceType { get; set; } = string.Empty;

        public string? Notes { get; set; }
     
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Review> Reviews { get; set; }
    }
}
