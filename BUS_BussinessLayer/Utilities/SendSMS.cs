using System;
using System.Collections.Generic;
using System.Drawing;
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
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("kem15122002@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Test send email";
                mail.Body = "Nếu chú nhận được email này và có kèm file báo cáo thì chức năng gửi mail đã thành công";
                // if (bitmap == null)
                // {
                //     MessageBox.Show("Bạn cần đính kèm tệp trước khi gửi");
                //     //MailMessage mail = new MailMessage();
                //     openFileDialog1.ShowDialog();
                //     //System.Net.Mail.Attachment attachment;
                //     attachment = new System.Net.Mail.Attachment(openFileDialog1.FileName);
                //     mail.Attachments.Add(attachment);
                //     txt_Attach.Text = Convert.ToString(openFileDialog1.FileName);
                // }
                var image = GenerateBarcode.CreateQRCode("123", "12");
                ImageConverter imageConverter = new ImageConverter();
                byte[] result = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
                MemoryStream memoryStream = new MemoryStream(result);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nbui04953@gmail.com", "16012002t");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Đã gửi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
