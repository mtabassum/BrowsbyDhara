namespace BrowsbyDhara.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; } // PK
        public int CustomerId { get; set; } // FK
        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TipAmount { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string? CancellationReason { get; set; }

        
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public ICollection<AppointmentService> AppointmentServices { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
