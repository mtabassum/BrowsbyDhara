namespace BrowsbyDhara.Models.Domain
{
    public class ServiceInfo
    {
        public string Title { get; set; } = "";
        public string Headline { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Benefits { get; set; } = new();
        public List<PriceItem> PriceList { get; set; } = new();
    }
}
