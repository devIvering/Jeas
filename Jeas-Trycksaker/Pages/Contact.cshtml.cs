using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;

namespace Jeas_Trycksaker.Pages
{
    public class ContactModel : PageModel
    {
        public void OnPost(string message)
        {
            string toEmail = "recipient@example.com";

            // Skapa en MailMessage och sätt avsändare, mottagare, ämne och meddelande
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("your-email@example.com");
            mail.To.Add(toEmail);
            mail.Subject = "Nytt meddelande från kontaktformuläret";
            mail.Body = message;

            // Skapa en SmtpClient och skicka meddelandet
            SmtpClient smtp = new SmtpClient("smtp.example.com");
            smtp.Send(mail);
        }
    }
}
