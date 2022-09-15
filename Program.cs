using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SendEmailWithGoogleSMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromMail = "ymineaowaluk@gmail.com";
            //keyนี้ขอมาจากGoogle
            string fromPassword = "lfrgfcsjuymcfcpj"; 

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Test Subject";
            message.To.Add(new MailAddress("lohmaxyaowaluk@gmail.com"));
            message.Body = "<html><body> Hello World </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, 
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
