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

            // Skapa en MailMessage och s�tt avs�ndare, mottagare, �mne och meddelande
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("your-email@example.com");
            mail.To.Add(toEmail);
            mail.Subject = "Nytt meddelande fr�n kontaktformul�ret";
            mail.Body = message;

            // Skapa en SmtpClient och skicka meddelandet
            SmtpClient smtp = new SmtpClient("smtp.example.com");
            smtp.Send(mail);
        }
    }
}
