using System.Net.Mail;
using System.Net;
using PiramalSchoolOfLeadership.Models;

namespace PiramalSchoolOfLeadership.Controllers
{
    public class MailSendHelper
    {
        private const string SmtpServer = "smtp.office365.com";
        private const int SmtpPort = 587;      
        public static async Task<bool> SendEmailAsync(string subject, string body, string userName, string password, string displayName, bool isHtml = false)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(userName, displayName);
                    mail.To.Add(userName);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = isHtml;
                    mail.Priority = MailPriority.Normal; // You can set High, Low, or Normal

                    using (SmtpClient smtp = new SmtpClient(SmtpServer, SmtpPort))
                    {
                        smtp.UseDefaultCredentials = false; // Important: We are providing explicit credentials
                        smtp.Credentials = new NetworkCredential(userName, password);
                        smtp.EnableSsl = true; // Use STARTTLS encryption
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Timeout = 20000; // Set a timeout (e.g., 20 seconds)

                        await smtp.SendMailAsync(mail); // Use SendMailAsync for asynchronous operation
                        //Console.WriteLine($"Email sent successfully to {recipientEmail}");
                        return true;
                    }
                }
            }
            catch (SmtpException smtpEx)
            {             
                if (smtpEx.InnerException != null)
                {
                    //Console.WriteLine($"Inner Exception: {smtpEx.InnerException.Message}");
                }
                return false;
            }
            catch (Exception ex)
            {              
                // Log inner exception if available
                if (ex.InnerException != null)
                {
                    //Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return false;
            }
        }
    }
}
