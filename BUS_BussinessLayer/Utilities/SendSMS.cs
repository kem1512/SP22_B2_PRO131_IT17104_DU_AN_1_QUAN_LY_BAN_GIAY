using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_BussinessLayer.Utilities
{
    public static class SendSMS
    {
        public static void SendMail(string email, string subject, string body, Bitmap bitmap)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("kem15122002@gmail.com");
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = body;
                var stream = new MemoryStream();
                bitmap.Save(stream, ImageFormat.Jpeg);
                stream.Position = 0;
                mail.Attachments.Add(new Attachment(stream, "image.jpg"));
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("kem15122002@gmail.com", "badao12345");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                MessageBox.Show("Đã gửi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static Stream ToStream(this Bitmap ms)
        {
            var stream = new MemoryStream();
            ms.Save(stream, ImageFormat.Bmp);
            return stream;
        }
        static Attachment ToAttachment(Bitmap bmp)
        {
            const string contentType = "image.jpg";
            return new Attachment(bmp.ToStream(), contentType);
        }
    }
}
