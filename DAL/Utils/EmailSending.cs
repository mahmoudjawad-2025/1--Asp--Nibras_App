
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace D_A_L.Utils
{
    public class EmailSending : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("mahmoodjawad1111@gmail.com", "unwa axnu fmvw dtkz")
            };

            return client.SendMailAsync(
                new MailMessage(from: "mahmoodjawad1111@gmail.com",
                                to: email,
                                subject,
                                htmlMessage
                )
                { IsBodyHtml = true });
        }
    }
}
