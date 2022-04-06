using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using PdfDocument = Syncfusion.Pdf.PdfDocument;
using PdfFont = Syncfusion.Pdf.Graphics.PdfFont;
using PdfPage = Syncfusion.Pdf.PdfPage;
using PdfRectangle = Syncfusion.Pdf.Graphics.PdfRectangle;
using Rectangle = System.Drawing.Rectangle;

namespace BUS_BussinessLayer.Utilities
{
    public static class GenerateInvoice
    {
        public static string PrintInvoice(Form form)
        {
            using (var bmp = new Bitmap(form.Width, form.Height))
            {
                form.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.PageSettings.SetMargins(0);
                PdfPage pdfPage = pdfDocument.Pages.Add();
                PdfGraphics pdfGraphics = pdfPage.Graphics;
                PdfBitmap pdfBitmap = new PdfBitmap(bmp);
                RectangleF rectangleF = new RectangleF(new PointF(0, 0), new SizeF(pdfPage.Size.Width, pdfPage.Size.Height));
                pdfGraphics.DrawImage(pdfBitmap, rectangleF);
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfDocument.Save(openFileDialog.FileName);
                }
            }
            return "In thất bại!";
        }
    }
}
