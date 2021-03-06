using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmailServiceExample.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("maksim.mystafa", "maksim.mystafa@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("Dotnet Training Academy", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("Plain")
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 587, false);

                await client.AuthenticateAsync("maksim.mystafa@yandex.ru", "Z#K63tz,6N,Ae*d");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
