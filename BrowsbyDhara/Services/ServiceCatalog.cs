using BrowsbyDhara.Models.Domain;

namespace BrowsbyDhara.Services
{
    public class ServiceCatalog : IServiceCatalog
    {
        private readonly Dictionary<string, ServiceInfo> services = new()
        {
            ["eyebrow-threading"] = new ServiceInfo
            {
                Title = "Eyebrow Threading",
                Headline = "Perfect Brows Every Time",
                Description = "Threading is an ancient hair removal technique that uses a twisted cotton thread to remove unwanted hair. It's precise, gentle on the skin, and perfect for shaping eyebrows.",
                Benefits = new List<string>
            {
                "Precise hair removal for perfect shape",
                "Chemical-free and suitable for sensitive skin",
                "Results last 4-6 weeks",
                "Less irritation than waxing",
                "Creates cleaner, more defined lines"
            },
                PriceList = new List<PriceItem>
            {
                new PriceItem { ServiceName = "Eyebrow Threading", Price = 15 },
                new PriceItem { ServiceName = "Eyebrow Threading + Tint", Price = 25 },
                new PriceItem { ServiceName = "Eyebrow Threading + Upper Lip", Price = 22 }
            }
            },
            ["makeup"] = new ServiceInfo
            {
                Title = "Professional Makeup",
                Headline = "Enhance Your Natural Beauty",
                Description = "Our professional makeup services are perfect for any occasion. From natural everyday looks to glamorous evening styles, we use high-quality products to create your perfect look.",
                Benefits = new List<string>
            {
                "Professional-grade cosmetics",
                "Customized to your skin tone and type",
                "Long-lasting application techniques",
                "Complimentary consultation included",
                "Touch-up kit provided for events"
            },
                PriceList = new List<PriceItem>
            {
                new PriceItem { ServiceName = "Everyday Makeup", Price = 45 },
                new PriceItem { ServiceName = "Party Makeup", Price = 65 },
                new PriceItem { ServiceName = "Bridal Makeup", Price = 150 },
                new PriceItem { ServiceName = "Makeup Lesson", Price = 75 }
            }
            },
            ["facial"] = new ServiceInfo
            {
                Title = "Facial Treatments",
                Headline = "Rejuvenate Your Skin",
                Description = "Experience our luxurious facial treatments designed to cleanse, nourish, and revitalize your skin. Each treatment is customized to your specific skin type and concerns.",
                Benefits = new List<string>
            {
                "Deep pore cleansing",
                "Improved skin texture and tone",
                "Reduced signs of aging",
                "Relaxing and stress-relieving",
                "Customized treatment plans"
            },
                PriceList = new List<PriceItem>
            {
                new PriceItem { ServiceName = "Express Facial (30 min)", Price = 45 },
                new PriceItem { ServiceName = "Deep Cleansing Facial", Price = 75 },
                new PriceItem { ServiceName = "Anti-Aging Facial", Price = 95 },
                new PriceItem { ServiceName = "Hydrating Facial", Price = 85 }
            }
            }
        };

        public IReadOnlyDictionary<string, ServiceInfo> GetServices() => services;

        public ServiceInfo? GetService(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return null;

            services.TryGetValue(key.ToLowerInvariant(), out var service);
            return service;
        }
        public List<string> GetServiceTitles()
            => services.Values.Select(s => s.Title).ToList();


    }
}
