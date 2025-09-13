namespace BrowsbyDhara.Models
{
    public class Review
    {
        public int ReviewId { get; set; } // PK
        public int CustomerId { get; set; } // FK
        public int AppointmentId { get; set; } // FK
        public int Rating { get; set; } // 1-5
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool IsPublished { get; set; }

    
        public Customer Customer { get; set; }
        public Appointment Appointment { get; set; }
    }
}
