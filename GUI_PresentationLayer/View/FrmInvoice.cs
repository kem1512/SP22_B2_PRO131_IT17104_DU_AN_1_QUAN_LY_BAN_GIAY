﻿using System;
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
using Color = System.Drawing.Color;

namespace GUI_PresentationLayer.View
{
    public partial class FrmInvoice : Form
    {
        private iInvoiceServices _iInvoiceServices = new InvoiceServices();
        private iCustomerServices _iCustomerServices = new CustomerServices();
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        private FrmMain _frmMain;
        public FrmInvoice(FrmMain form)
        {
            InitializeComponent();
            LoadData();
            _frmMain = form;
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
                    b.First().Invoice.ShipperId,
                    b.First().Invoice.GuestPayments
                };
            foreach (var x in result)
            {
                dgridInvoice.Rows.Add(x.InvoiceId, x.DateCreate, x.CustomerName, x.FullName, x.ProductCount, ConvertMoney.ConvertToVND(x.TotalPrice), x.Description,
                    x.InvoiceStatus ? "Đã hoàn thành" : !x.InvoiceStatus && x.Description != null ? "Đã hủy" : !x.InvoiceStatus && x.ShipperId != null ? "Đang giao hàng": x.GuestPayments <= 0 ? "Chưa thanh toán" : "Chưa hoàn thành");
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
                GenerateDoucument.PrintInvoice(invoice);
            }
        }

        private void dgdtpcDateBegin_onValueChanged(object sender, EventArgs e)
        {
            if (dgdtpcDateBegin.Value < dgdtpcDateEnd.Value)
            {
                foreach (DataGridViewRow x in dgridInvoice.Rows)
                {
                    x.Visible = DateTime.Parse(x.Cells[1].Value.ToString()).Date <= dgdtpcDateEnd.Value.Date && DateTime.Parse(x.Cells[1].Value.ToString()).Date >= dgdtpcDateBegin.Value.Date;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgridInvoice.CurrentRow != null)
            {
                var id = dgridInvoice.Rows[dgridInvoice.CurrentRow.Index].Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn số " + id, "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iInvoiceServices.RemoveInvoice(id));
                    LoadData();
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0 && dgdtpcDateBegin.Value < dgdtpcDateEnd.Value)
            {
                foreach (DataGridViewRow x in dgridInvoice.Rows)
                {
                    if(!x.Visible) x.Visible = DateTime.Parse(x.Cells[1].Value.ToString()).Date <= dgdtpcDateEnd.Value.Date && DateTime.Parse(x.Cells[1].Value.ToString()).Date >= dgdtpcDateBegin.Value.Date;
                }
            }else if (cmbFilter.SelectedIndex == 0)
            {
                foreach (DataGridViewRow x in dgridInvoice.Rows)
                {
                    if (!x.Visible) x.Visible = true;
                }
            }
            else
            {
                foreach (DataGridViewRow x in dgridInvoice.Rows)
                {
                    x.Visible = x.Cells[7].Value.ToString().Equals(cmbFilter.SelectedItem);
                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex != -1 || dgdtpcDateBegin.Value < dgdtpcDateEnd.Value)
            {
                foreach (DataGridViewRow x in dgridInvoice.Rows)
                {
                    if(x.Visible )x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
                }
            }
            else
            {
                foreach (DataGridViewRow x in dgridInvoice.Rows)
                {
                    if (x.Visible) x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            _frmMain.OpenChildForm(new FrmStatistics());
        }
    }
}
