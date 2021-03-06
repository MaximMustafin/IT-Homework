using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmailServiceExample.Services.EmailService
{
    public interface IEmailService
    {
        /// <summary>
        /// Отправка email сообщения
        /// </summary>
        /// <param name="email">Почта назначения</param>
        /// <param name="subject">Тема сообщения</param>
        /// <param name="message">Содержание сообщения</param>
        /// <returns></returns>
        Task SendEmailAsync(string email, string subject, string message);


    }
}
