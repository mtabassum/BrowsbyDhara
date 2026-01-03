using BrowsbyDhara.Models;

namespace BrowsbyDhara.Services
{
    public interface IEmailService
    {
        Task SendAppointmentRequestEmailAsync(
        string toEmail,
        string subject,
        string message
    );
    
    }
}
