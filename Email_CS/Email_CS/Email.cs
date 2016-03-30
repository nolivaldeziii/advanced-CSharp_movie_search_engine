using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

namespace Email_CS
{
    public class Email
    {
        string myEmail, name, targetEmail, targetName, pw;
        string subject, e_message;

        public Email()
        {
            myEmail = "mapua.moviesearchengine@gmail.com";
                name = "engineer engine";
                pw = "moviesearch";
        }

        public void getMessage(string s, string m)
        {
            subject = s;
            e_message = m;
        }
        public void getTarget(string str)
        {
            targetEmail = str;
        }
        public void getName(string str)
        {
            targetName = str;
        }

        public bool VerifyEmail(string code)
        {
            string welcome_m = "Thanks for using Movie Search Engine\n" 
                    +"Confirm your email address to get the full benefits of your account:";
            getMessage(string.Format("Welcome to Movie Search Engine - please confirm your email address"),
                string.Format("{2}\nDear {0} Please enter this verification on your account thank you\n"
                        +"verification code: {1}",targetName,code,welcome_m));

            SmtpClient myClient = new SmtpClient("smtp.gmail.com", 587);
            myClient.EnableSsl = true;
            MailAddress from = new MailAddress(myEmail, name);
            MailAddress to = new MailAddress(targetEmail, targetName);
            MailMessage message = new MailMessage(from, to);

            message.Body = e_message;
            message.Subject = subject;

            NetworkCredential mycredentials = new NetworkCredential(myEmail, pw, "");
            myClient.Credentials = mycredentials;
            try
            {
                myClient.Send(message);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
            //Console.WriteLine("Enter your email");
            //myEmail = Console.ReadLine();
            //Console.WriteLine("Enter your password");
            //pw = Console.ReadLine();
            //Console.WriteLine("Enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter your recipient email");
            //targetEmail = Console.ReadLine();
            //Console.WriteLine("Enter your recipient name");
            //targetName = Console.ReadLine();

            //SmtpClient myClient = new SmtpClient("smtp.gmail.com", 587);
            //myClient.EnableSsl = true;
            //MailAddress from = new MailAddress(myEmail, name);
            //MailAddress to = new MailAddress(targetEmail, targetName);
            //MailMessage message = new MailMessage(from, to);
            //message.Body = "this is a test e-mail message using c#";
            //message.Subject = "test email";
            //NetworkCredential  mycredentials= new NetworkCredential(myEmail, pw, "");
            //myClient.Credentials = mycredentials;
            //try
            //{
            //    myClient.Send(message);
            //    Console.WriteLine("Message sent!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("EXCEPTION" + ex.ToString());

            //}
            //Console.WriteLine("SHUTTING DOWN");

            //Console.ReadKey();

    }
}
