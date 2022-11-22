using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.Models;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.iDAL_Services;
using Ganss.Excel;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;

namespace BUS_BussinessLayer.Utilities
{
    public static class GenerateDoucument
    {
        public static string ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                // worksheet.Name = "Quản lý học sinh";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].Name;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                return "Xuất dữ liệu ra Excel thành công!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        public static List<T> AddMultipleFromExcel<T>(string fileName)
        {
            try
            {
                var result = new ExcelMapper(fileName).Fetch<T>().ToList();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static string PrintInvoice(List<ViewInvoice> viewInvoices)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF File |*.pdf|All File|*.*";
            saveFileDialog.FileName = "invoice.pdf";
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
                    pdfLightTable.Style = new PdfLightTableStyle() { ShowHeader = true, DefaultStyle = new PdfCellStyle(new PdfTrueTypeFont(@"C:\Users\kem15\source\repos\DU_AN_1_QUAN_LY_BAN_GIAY\Font\Roboto.ttf", 12), new PdfSolidBrush(PdfColor.Empty), new PdfPen(Color.Red)), CellPadding = 8 };
                    table.Rows.Add(i, _iDalProduct.GetProductById(viewInvoices[i].InvoiceDetail.ProductId).ProductName, viewInvoices[i].InvoiceDetail.Quantity, string.Format("{0:0,0 VNĐ}", viewInvoices[i].InvoiceDetail.Price), string.Format("{0:0,0} VNĐ", viewInvoices[i].InvoiceDetail.TotalPrice));
                    totalPrice += viewInvoices[i].InvoiceDetail.TotalPrice;
                }
                pdfLightTable.DataSource = table;
                PdfGraphics pdfGraphics = pdfPage.Graphics;
                PdfFont pdfFont = new PdfTrueTypeFont(@"C:\Users\kem15\source\repos\DU_AN_1_QUAN_LY_BAN_GIAY\Font\Roboto.ttf", 12);
                pdfGraphics.DrawString("Hóa đơn mua hàng", pdfFont, new PdfPen(Color.Red), new PointF(0, 0));
                var customer = _iDalCustomer.GetCustomerById(viewInvoices.First().Invoice.CustomerId);
                pdfGraphics.DrawString("Tên khách hàng: " + customer.CustomerName, pdfFont, new PdfPen(Color.Black), new PointF(0, 18));
                pdfGraphics.DrawString("Mã hóa đơn: : " + viewInvoices.First().Invoice.InvoiceId, pdfFont, new PdfPen(Color.Black), new PointF(400, 36));
                pdfGraphics.DrawString("Địa chỉ: " + customer.Address, pdfFont, new PdfPen(Color.Black), new PointF(0, 36));
                pdfGraphics.DrawString("Số điện thoại: " + customer.Phone, pdfFont, new PdfPen(Color.Black), new PointF(0, 54));
                pdfLightTable.Draw(pdfPage, new PointF(0, 80));
                pdfGraphics.DrawString(viewInvoices.First().Invoice.DateCreate.ToString(), pdfFont, new PdfPen(Color.Black), new PointF(380, 54));
                pdfGraphics.DrawString("Tổng tiền: " + string.Format("{0:0,0 VNĐ}", totalPrice), pdfFont, new PdfPen(Color.Red), new PointF(0, 80 + (45 * (viewInvoices.Count + 1))));
                pdfGraphics.DrawString("Tiền khách trả: " + string.Format("{0:0,0 VNĐ}", viewInvoices.First().Invoice.GuestPayments), pdfFont, new PdfPen(Color.Black), new PointF(0, 80 + (45 * (viewInvoices.Count + 1)) + 18));
                pdfGraphics.DrawString("Tiền thừa: " + string.Format("{0:0,0 VNĐ}", viewInvoices.First().Invoice.GuestPayments - totalPrice), pdfFont, new PdfPen(Color.Black), new PointF(0, 80 + (45 * (viewInvoices.Count + 1)) + 36));
                pdfGraphics.DrawString("Nhân viên phụ trách ", pdfFont, new PdfPen(Color.Black), new PointF(380, 80 + (35 * (viewInvoices.Count + 1)) + 54));
                pdfGraphics.DrawString(_iDalEmployee.GetEmployeeById(viewInvoices.First().Invoice.EmployeeId).FullName, pdfFont, new PdfPen(Color.Black), new PointF(410, 80 + (35 * (viewInvoices.Count + 1)) + 72));
                pdfDocument.Save(saveFileDialog.FileName);
                pdfDocument.Close();
            }
            return null;
        }
    }
}
