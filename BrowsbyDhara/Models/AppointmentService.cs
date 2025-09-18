namespace BrowsbyDhara.Models
{
    public class AppointmentService
    {
        public int AppointmentServiceId { get; set; } // PK
        public int AppointmentId { get; set; } // FK
        public int ServiceId { get; set; } // FK
        public decimal ServicePrice { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public Appointment Appointment { get; set; }
        public Service Service { get; set; }
    }
}
