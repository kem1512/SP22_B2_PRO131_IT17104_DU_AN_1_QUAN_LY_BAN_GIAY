using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DAL_DataAccessLayer.Entities;
using Ganss.Excel;

namespace BUS_BussinessLayer.Utilities
{
    public static class GenerateExcel
    {
        public static void ToExcel(DataGridView dataGridView1, string fileName)
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
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        public static List<T> AddMultipleFromExcel<T>()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var result = new ExcelMapper(openFileDialog.FileName).Fetch<T>().ToList();
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static List<T> Import<T>(string excelFilePath, string sheetName)
        {
            List<T> list = new List<T>();
            Type typeofObject = typeof(T);
            using (IXLWorkbook workbook = new XLWorkbook(excelFilePath))
            {
                var workSheet = workbook.Worksheets.Where(w => w.Name == sheetName).First();
                var props = typeofObject.GetProperties();
                //header column text
                var columns = workSheet.FirstRow().Cells().Select((v, i) => new { Value = v.Value, Index = i + 1 });//index start with 1
                foreach (IXLRow row in workSheet.RowsUsed().Skip(1))//Skip row 1 that used for column header
                {
                    T obj = (T)Activator.CreateInstance(typeofObject);//Dynamic obj
                    foreach (var pro in props)
                    {
                        int colIndex = columns.SingleOrDefault(c => c.Value.ToString() == pro.Name.ToString()).Index;
                        var val = row.Cell(colIndex).Value;
                        var type = pro.PropertyType;
                        pro.SetValue(obj, Convert.ChangeType(val, type));
                    }
                    list.Add(obj);
                }
            }
            return list;
        }
    }
}
