namespace BrowsbyDhara.Models
{
    public class Payment
    {
        public int PaymentId { get; set; } // PK
        public int AppointmentId { get; set; } // FK
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public string TransactionId { get; set; }
        public DateTime PaymentDate { get; set; }


        public Appointment Appointment { get; set; }
    }
}
