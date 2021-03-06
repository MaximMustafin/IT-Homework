using EmailServiceExample.Services.EmailService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EmailServiceExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IEmailService emailService;
        public string State { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IEmailService emailService)
        {
            _logger = logger;
            this.emailService = emailService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(string emailTo, string message)
        {
            await emailService.SendEmailAsync(emailTo, "I learnt to send an email", message);
            this.State = "Your message has been sent";
            return Page();
        }
    }
}
