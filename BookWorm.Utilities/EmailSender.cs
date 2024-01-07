using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BookWorm.Utilities
{
    public class EmailSender : IEmailSender
    {
        private string SendGridSecretKey { get; set; }
        public EmailSender(IConfiguration _config)
        {
            SendGridSecretKey = _config.GetValue<string>("SendGrid:SecretKey");
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(SendGridSecretKey);
            var from = new EmailAddress("hello@bookworm.com");
            var to = new EmailAddress(email);
            var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
            return client.SendEmailAsync(message);
        }
    }
}
