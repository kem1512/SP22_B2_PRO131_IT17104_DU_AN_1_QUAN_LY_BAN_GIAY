using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using BUS_BussinessLayer.Utilities;

namespace GUI_PresentationLayer.View
{
    public partial class FrmReport : Form
    {
        private iInvoiceServices _iInvoiceServices = new InvoiceServices();
        private iCustomerServices _iCustomerServices = new CustomerServices();
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        public FrmReport(string email)
        {
            InitializeComponent();
            this.Email = email;

        }

        public string Email { get; set; }

        private void LoadData()
        {
            dgridInvoice.Rows.Clear();
            var result = from a in _iInvoiceServices.GetViewInvoices()
                group a by a.Invoice.InvoiceId
                into b
                select new
                {
                    b.First().Invoice.InvoiceId,
                    b.First().Invoice.DateCreate,
                    _iCustomerServices.GetCustomerById(b.First().Invoice.CustomerId).CustomerName,
                    _iEmployeeServices.GetEmployeeById(b.First().Invoice.EmployeeId).FullName,
                    b.First().Invoice.Description,
                    b.First().Invoice.InvoiceStatus,
                    TotalPrice = b.Sum(c => c.InvoiceDetail.TotalPrice),
                    ProductCount = b.Count(c => c.Invoice.InvoiceId == c.InvoiceDetail.InvoiceId),
                    b.First().Invoice.ShipperId
                };
            foreach (var x in result.Where(c => c.DateCreate.Date.Equals(DateTime.Now.Date)))
            {
                dgridInvoice.Rows.Add(x.InvoiceId, x.DateCreate, x.CustomerName, x.FullName, x.ProductCount, ConvertMoney.ConvertToVND(x.TotalPrice), x.Description,
                    x.InvoiceStatus ? "Đã hoàn thành" : !x.InvoiceStatus && x.Description != null ? "Đã hủy" : !x.InvoiceStatus && x.ShipperId != null ? "Đang giao hàng" : "Chưa hoàn thành");
            }
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            LoadData();
            var done = 0;
            var ship = 0;
            var cancel = 0;
            float total = 0;
            foreach (DataGridViewRow x in dgridInvoice.Rows)
            {
                if (x.Cells[7].Value == "Đã hoàn thành")
                {
                    done++;
                }
                if (x.Cells[7].Value == "Đang giao hàng")
                {
                    ship++;
                }
                if (x.Cells[7].Value == "Đã hủy")
                {
                    cancel++;
                }
                total += float.Parse(x.Cells[5].Value.ToString());
            }
            lblSale.Text = done.ToString();
            lblShip.Text = ship.ToString();
            lblCancel.Text = cancel.ToString();
            lblTotalPrice.Text = ConvertMoney.ConvertToVND(total) + " VNĐ";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Email != null)
            {
                SendSMS.SendMail(Email, "Báo cáo hôm nay", "Số đơn bán được");
            }
        }
    }
}
