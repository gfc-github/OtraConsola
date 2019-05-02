using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestCorreo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("gflores@adamantine.com.mx");
                mail.To.Add("gfcmotog@gmail.com");
                mail.Subject = "Test Correo";
                mail.IsBodyHtml = true;
                mail.Body = "Prueba de correo desde Console";
                smtpserver.Host = "";
                smtpserver.Send(mail);
                smtpserver.Dispose();
                mail.Dispose();

            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
    }
}
