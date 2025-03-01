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
                             b.First().Invoice.ShipperId,
                             b.First().Invoice.GuestPayments
                         };
            foreach (var x in result.Where(c => c.DateCreate.Date.Equals(DateTime.Now.Date)))
            {
                dgridInvoice.Rows.Add(x.InvoiceId, x.DateCreate, x.CustomerName, x.FullName, x.ProductCount, ConvertMoney.ConvertToVND(x.TotalPrice), x.Description,
                    x.InvoiceStatus ? "Đã hoàn thành" : !x.InvoiceStatus && x.Description != null ? "Đã hủy" : !x.InvoiceStatus && x.ShipperId != null ? "Đang giao hàng" : x.GuestPayments <= 0 ? "Chưa thanh toán" : "Chưa hoàn thành");
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
                if (x.Cells[7].Value.ToString() == "Đã hoàn thành")
                {
                    done++;
                }
                if (x.Cells[7].Value.ToString() == "Đang giao hàng")
                {
                    ship++;
                }
                if (x.Cells[7].Value.ToString() == "Đã hủy")
                {
                    cancel++;
                }

                if (x.Cells[7].Value.ToString() == "Đã hoàn thành")
                {
                    total += float.Parse(x.Cells[5].Value.ToString());
                }
            }
            lblSale.Text = done.ToString();
            lblShip.Text = ship.ToString();
            lblCancel.Text = cancel.ToString();
            lblTotalPrice.Text = ConvertMoney.ConvertToVND(total) + " VNĐ";
        }

        private void ShowMail()
        {
            Form form = new Form();
            TextBox textBox = new TextBox();
            Button button = new Button();
            button.Text = "Xác nhận";
            textBox.Multiline = true;
            textBox.Height = 150;
            button.Height = 100;
            button.Click += (o, args) =>
            {
                if (textBox.Text.Trim() != "")
                {
                    if (!textBox.Text.Contains("@") && !textBox.Text.Contains("."))
                    {
                        MessageBox.Show("Không đúng định dạng email");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc muốn gửi mail đến " + textBox.Text, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SendSMS.SendMail(Email, "Báo cáo hôm nay", $"Số đơn bán được: {lblSale.Text} \nSố hóa đơn hủy: {lblShip.Text} \nSố đơn đang giao: {lblShip.Text} \nTổng tiền trong ngày: {lblTotalPrice.Text}");
                            MessageBox.Show("Gửi thành công!");
                            form.Close();
                        }
                    }
                }
            };
            textBox.Dock = DockStyle.Top;
            button.Dock = DockStyle.Top;
            textBox.Font = new Font("Arial", 12);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Controls.Add(button);
            form.Controls.Add(textBox);
            form.MaximizeBox = false;
            form.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowMail();
        }
    }
}
