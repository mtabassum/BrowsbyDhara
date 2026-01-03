using BrowsbyDhara.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net;
using System.Net.Mail;

namespace BrowsbyDhara.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        private readonly ILogger _logger;

        public EmailService(IConfiguration config, ILogger<EmailService> logger)
        {
            _config = config;
            _logger = logger;
        }

        public async Task SendAppointmentRequestEmailAsync(string toEmail, string subject, string message)
        {
            var apiKey = _config["EmailSettings:SendGridApiKey"];
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new Exception("SendGrid API key is not configured");
            }

            var client = new SendGridClient(apiKey);

            var fromEmail = _config["EmailSettings:FromEmail"];
            var fromName = _config["EmailSettings:FromName"];

            var msg = new SendGridMessage
            {
                From = new EmailAddress(fromEmail, fromName),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message.Replace("\n", "<br/>")
            };

            msg.AddTo(new EmailAddress(toEmail));

            var response = await client.SendEmailAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                _logger.LogInformation("Email sent successfully");
            }
            else
            {
                _logger.LogError("Failed to send email. Status: {Status}", response.StatusCode);
            }
        }
    }
    }


