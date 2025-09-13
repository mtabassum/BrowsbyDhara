namespace BrowsbyDhara.Models
{
    public class ServiceCategory
    {
        public int CategoryId { get; set; } // PK
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
