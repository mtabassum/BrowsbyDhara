using BrowsbyDhara.Models;
using BrowsbyDhara.Models.DTOs;

namespace BrowsbyDhara.Services
{
    public interface IAppointmentService
    {
        Task CreateAppointmentAsync(AppointmentRequestDto appointment);
    }
}
