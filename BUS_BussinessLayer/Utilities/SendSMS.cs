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
        public static void SendMailQr(string email, string subject, string body, Bitmap bitmap)
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
                smtpClient.Credentials = new NetworkCredential("kem15122002@gmail.com", "badao12345");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                MessageBox.Show("Đã gửi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string SendMail(string email, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("kem15122002@gmail.com");
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = body;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("kem15122002@gmail.com", "badao12345");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                return "Đã gửi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "Gửi thất bại!";
        }

        public static void SendMailWithImage(string email, string subject, string body, string path)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("kem15122002@gmail.com");
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = body;
                mail.Attachments.Add(new Attachment(path));
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("kem15122002@gmail.com", "badao12345");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                MessageBox.Show("Đã gửi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static string SendCode(string email)
        {
            try
            {
                var code = CreatePassword(6);
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("kem15122002@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Đổi mật khẩu";
                mail.Body = "Mã xác nhận của bạn là: " + code;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("kem15122002@gmail.com", "badao12345");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                return code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "Gửi thất bại!";
        }
    }
}
