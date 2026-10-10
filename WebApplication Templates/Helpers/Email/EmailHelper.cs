using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Helpers.Email
{
    public class EmailHelper : IEmailHelper
    {
        public void SendMessage(EmialViewModels model)
        {
            var fromEmail = "########################";
            var appPassword = "##################";

            var smtpServer = "smtp.gmail.com";
            var smtpPort = 465;

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(
                new MailboxAddress("Bashir Ebdah", fromEmail)
            );

            emailMessage.To.Add(
                MailboxAddress.Parse(model.EmialAddrase)
            );

            emailMessage.Subject = model.Subject;

            emailMessage.Body = new TextPart("plain")
            {
                Text = model.Message
            };

            using var client = new SmtpClient();

            client.Connect(
                smtpServer,
                smtpPort,
                SecureSocketOptions.SslOnConnect
            );

            client.Authenticate(fromEmail, appPassword);

            client.Send(emailMessage);

            client.Disconnect(true);
        }
    }
}