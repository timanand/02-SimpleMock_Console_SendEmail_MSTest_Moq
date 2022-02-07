using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace ConsoleApp1
{
    public class MyEmail
    {

        public virtual bool SendEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.questpond.com");

            mail.From = new MailAddress("questpond@questpond.com");
            mail.To.Add("questpond@questpind.com");
            mail.Subject = "Customer Inserted";
            mail.Body = "Customer inserted successfully";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return true;
        }


    }
}
