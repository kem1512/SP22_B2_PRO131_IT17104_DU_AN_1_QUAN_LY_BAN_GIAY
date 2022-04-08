using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.Models;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using Color = System.Drawing.Color;
using PdfDocument = Syncfusion.Pdf.PdfDocument;
using PdfFont = Syncfusion.Pdf.Graphics.PdfFont;
using PdfPage = Syncfusion.Pdf.PdfPage;
using PdfRectangle = Syncfusion.Pdf.Graphics.PdfRectangle;
using Rectangle = System.Drawing.Rectangle;

namespace BUS_BussinessLayer.Utilities
{
    public static class GenerateInvoice
    {
        public static string PrintInvoice(List<ViewInvoice> viewInvoices)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                iDAL_Product _iDalProduct = new DAL_Product();
                iDAL_Customer _iDalCustomer = new DAL_Customer();
                iDAL_Employee _iDalEmployee = new DAL_Employee();
                PdfDocument pdfDocument = new PdfDocument();
                PdfPage pdfPage = pdfDocument.Pages.Add();
                PdfLightTable pdfLightTable = new PdfLightTable();
                DataTable table = new DataTable();
                table.Columns.Add("STT");
                table.Columns.Add("Tên sản phẩm");
                table.Columns.Add("Số lượng");
                table.Columns.Add("Đơn giá");
                table.Columns.Add("Thành tiền");
                double totalPrice = 0;
                for (int i = 0; i < viewInvoices.Count; i++)
                {
                    pdfLightTable.Style = new PdfLightTableStyle() { ShowHeader = true, DefaultStyle = new PdfCellStyle(new PdfTrueTypeFont(@"C:\Users\kem15\Downloads\QuanLyBanGiay\Font\Roboto.ttf", 12), new PdfSolidBrush(PdfColor.Empty), new PdfPen(Color.Red)), CellPadding = 8 };
                    table.Rows.Add(i,_iDalProduct.GetProductById(viewInvoices[i].InvoiceDetail.ProductId).ProductName , viewInvoices[i].InvoiceDetail.Quantity, string.Format("{0:0,0 VNĐ}", viewInvoices[i].InvoiceDetail.Price), string.Format("{0:0,0} VNĐ", viewInvoices[i].InvoiceDetail.TotalPrice));
                    totalPrice += viewInvoices[i].InvoiceDetail.TotalPrice;
                }
                pdfLightTable.DataSource = table;
                PdfGraphics pdfGraphics = pdfPage.Graphics;
                PdfFont pdfFont = new PdfTrueTypeFont(@"C:\Users\kem15\Downloads\QuanLyBanGiay\Font\Roboto.ttf", 12);
                pdfGraphics.DrawString("Hóa đơn mua hàng", pdfFont, new PdfPen(Color.Red), new PointF(0, 0));
                var customer = _iDalCustomer.GetCustomerById(viewInvoices.First().Invoice.CustomerId);
                pdfGraphics.DrawString("Tên khách hàng: " + customer.CustomerName, pdfFont, new PdfPen(Color.Black), new PointF(0, 18));
                pdfGraphics.DrawString("Mã hóa đơn: : " + viewInvoices.First().Invoice.InvoiceId, pdfFont, new PdfPen(Color.Black), new PointF(400, 36));
                pdfGraphics.DrawString("Địa chỉ: " + customer.Address, pdfFont, new PdfPen(Color.Black), new PointF(0, 36));
                pdfGraphics.DrawString("Số điện thoại: " + customer.Phone, pdfFont, new PdfPen(Color.Black), new PointF(0, 54));
                pdfLightTable.Draw(pdfPage, new PointF(0, 80));
                pdfGraphics.DrawString(viewInvoices.First().Invoice.DateCreate.ToString(), pdfFont, new PdfPen(Color.Black), new PointF(380, 54));
                pdfGraphics.DrawString("Tổng tiền: " + string.Format("{0:0,0 VNĐ}", totalPrice), pdfFont, new PdfPen(Color.Red), new PointF(0, 80 + (35 * (viewInvoices.Count + 1))));
                pdfGraphics.DrawString("Tiền khách trả: " + string.Format("{0:0,0 VNĐ}", viewInvoices.First().Invoice.GuestPayments), pdfFont, new PdfPen(Color.Black), new PointF(0, 80 + (35 * (viewInvoices.Count + 1)) + 18));
                pdfGraphics.DrawString("Tiền khách trả: " + string.Format("{0:0,0 VNĐ}", viewInvoices.First().Invoice.GuestPayments - totalPrice), pdfFont, new PdfPen(Color.Black), new PointF(0, 80 + (35 * (viewInvoices.Count + 1)) + 36));
                pdfGraphics.DrawString("Nhân viên phụ trách ", pdfFont, new PdfPen(Color.Black), new PointF(380, 80 + (35 * (viewInvoices.Count + 1)) + 54));
                pdfGraphics.DrawString(_iDalEmployee.GetEmployeeById(viewInvoices.First().Invoice.EmployeeId).FullName, pdfFont, new PdfPen(Color.Black), new PointF(400, 80 + (35 * (viewInvoices.Count + 1)) + 72));
                pdfDocument.Save(saveFileDialog.FileName);
                pdfDocument.Close();
            }
            return null;
        }
    }
}
