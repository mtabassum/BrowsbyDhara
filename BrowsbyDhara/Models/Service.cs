namespace BrowsbyDhara.Models
{
    public class Service
    {
        public int ServiceId { get; set; } // PK
        public int CategoryId { get; set; } // FK
        public string ServiceName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }

    
        public ServiceCategory Category { get; set; }
    }
}
