namespace BrowsbyDhara.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // PK
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Email { get; set; } // Unique
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastVisitDate { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
