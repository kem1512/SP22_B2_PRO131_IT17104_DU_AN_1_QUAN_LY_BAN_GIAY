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
using BUS_BussinessLayer.Models;
using BUS_BussinessLayer.Utilities;
using DAL_DataAccessLayer.Entities;

namespace GUI_PresentationLayer.View
{
    public partial class FrmInvoice : Form
    {
        private iInvoiceServices _iInvoiceServices = new InvoiceServices();
        private iCustomerServices _iCustomerServices = new CustomerServices();
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        public FrmInvoice()
        {
            InitializeComponent();
            LoadData();
            cmbFilter.SelectedIndex = 0;
        }

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
            foreach (var x in result)
            {
                dgridInvoice.Rows.Add(x.InvoiceId, x.DateCreate, x.CustomerName, x.FullName, x.ProductCount, ConvertMoney.ConvertToVND(x.TotalPrice), x.Description,
                    x.InvoiceStatus ? "Đã hoàn thành" : !x.InvoiceStatus && x.Description != null ? "Đã hủy" : !x.InvoiceStatus && x.ShipperId != null ? "Đang giao hàng": "Chưa hoàn thành");
            }
        }

        private void dgridInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dgridInvoice.Rows[e.RowIndex];
                var result = _iInvoiceServices.GetInvoicesDetail().Where(c => c.InvoiceId == row.Cells[0].Value.ToString());
                dgidInvoiceDetail.Rows.Clear();
                foreach (var x in result)
                {
                    dgidInvoiceDetail.Rows.Add(x.ProductId, ConvertMoney.ConvertToVND(x.Price), x.Quantity, ConvertMoney.ConvertToVND(x.TotalPrice));
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Bạn có muốn in hóa đơn số: " + dgridInvoice.Rows[dgridInvoice.CurrentRow.Index].Cells[0].Value,
                    "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var invoice = _iInvoiceServices.GetViewInvoices().Where(c => c.Invoice.InvoiceId == dgridInvoice.Rows[dgridInvoice.CurrentRow.Index].Cells[0].Value.ToString()).ToList();
                GenerateInvoice.PrintInvoice(invoice);
            }
        }

        private void dgdtpcDateBegin_onValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dgridInvoice.Rows)
            {
                x.Visible = DateTime.Parse(x.Cells[1].Value.ToString()).Date <= dgdtpcDateEnd.Value.Date && DateTime.Parse(x.Cells[1].Value.ToString()).Date >= dgdtpcDateBegin.Value.Date;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
            {
                LoadData();
            }

            switch (cmbFilter.SelectedIndex)
            {
                case 0:
                    LoadData();
                    break;
                case 1:
                    foreach (DataGridViewRow x in dgridInvoice.Rows)
                    {
                        x.Visible = x.Cells[7].Value.ToString().Equals("Chưa hoàn thành");
                    }
                    break;
                case 2:
                    foreach (DataGridViewRow x in dgridInvoice.Rows)
                    {
                        x.Visible = x.Cells[7].Value.ToString().Equals("Đã hoàn thành");
                    }
                    break;
                case 3:
                    foreach (DataGridViewRow x in dgridInvoice.Rows)
                    {
                        x.Visible = x.Cells[7].Value.ToString().Equals("Đã hủy");
                    }
                    break;
                case 4:
                    foreach (DataGridViewRow x in dgridInvoice.Rows)
                    {
                        x.Visible = x.Cells[7].Value.ToString().Equals("Đang giao hàng");
                    }
                    break;
            }
        }
    }
}
