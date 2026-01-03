using BrowsbyDhara.Models.Domain;

namespace BrowsbyDhara.Services
{
    public interface IServiceCatalog
    {
        IReadOnlyDictionary<string, ServiceInfo> GetServices();
        ServiceInfo? GetService(string key);

        List<string> GetServiceTitles();

    }
}
