using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FrostGuard_Project
{
    class MailSystem
    {
        private MailMessage mail;
        private MailAddress fromMail;
        private MailAddress toMail;
        private SmtpClient client;

        public MailSystem()
        {
            this.mail = new MailMessage();
        }
        public bool SetSubject(string subject)
        {
            try
            {
                mail.Subject = subject;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SetSourceAddress(string address)
        {
            try
            {
                fromMail = new MailAddress(address);
                mail.From = fromMail;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SetRecipientAddress(string address)
        {
            try
            {
                toMail = new MailAddress(address);
                mail.To.Add(toMail);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SetClient(string client)
        {
            try
            {
                this.client = new SmtpClient(client);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SetCopyAddress(List<string> addresses)
        {
            try
            {
                foreach (string address in addresses)
                {
                    mail.CC.Add(new MailAddress(address));
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool WriteAMail(string message)
        {
            mail.Body = message;
            return true;
        }

        public bool SendEmail()
        {
            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
