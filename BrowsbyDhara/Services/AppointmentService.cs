using BrowsbyDhara.Data;
using BrowsbyDhara.Models;
using BrowsbyDhara.Models.DTOs;
using Microsoft.JSInterop.Infrastructure;

namespace BrowsbyDhara.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly SalonDbContext _context;
        private readonly IEmailService _emailService;

        public AppointmentService(SalonDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public async Task CreateAppointmentAsync(AppointmentRequestDto dto)
        {
            var appointment = new Appointment
            {
                Name = dto.Name,
                Email = dto.Email,
                RequestedDate = dto.DateRequested,
                PhoneNumber = dto.PhoneNumber,
                ServiceType = dto.Reason,
                Notes = dto.Notes,
                CreatedAt = DateTime.UtcNow
            };

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            // 3. Send email
            await _emailService.SendAppointmentRequestEmailAsync(
                toEmail: dto.Email,
                subject: "Appointment Request Received",
                message: $"Thank you {dto.Name}, we received your request."
            );
        }
    }
}

