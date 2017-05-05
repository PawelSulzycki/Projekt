using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public class Email
    {

        private string fromPassword;
        public string Taskss, Subject, Body, Addres;
        public Email(string Address, string subject, string body)
        {
            Taskss = subject + " : " + Address;
            Addres = Address;
            Subject = subject;
            Body = body;
        }

        public Email()
        {
        }

        public void SendEmail()
        {
            fromPassword = "poniedzialek19";
            var fromAddress = new MailAddress("platformypwr@gmail.com", "JTTWT");
            var toAddress = new MailAddress(Addres, "odbiorca");
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };

           var  message = new MailMessage(fromAddress, toAddress)
            {
                Subject = Subject,
                Body = Body,
                IsBodyHtml = true
            };
            smtp.Send(message);

        }
        public override string ToString()
        {

            return Taskss;

        }
    }
}
