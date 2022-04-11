using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using BUS_BussinessLayer.Utilities;

namespace GUI_PresentationLayer.View
{
    public partial class FrmSendMail : Form
    {
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        public FrmSendMail()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var result = _iEmployeeServices.GetEmployees();
            foreach (var x in result)
            {
                listBox1.Items.Add(x.Email);
            }
        }

        private void lblAttach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblAttach.Text = Path.GetFileName(openFileDialog.FileName);
                lblAttach.Tag = openFileDialog.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblAttach.Text != "Đính kèm")
            {
                if (MessageBox.Show("Bạn có chắc muốn gửi mail?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var x in listBox1.SelectedItems)
                    {
                        SendSMS.SendMailWithImage(x.ToString(), "Thông báo", textBox1.Text, lblAttach.Tag.ToString());
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn gửi mail?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var x in listBox1.SelectedItems)
                    {
                        SendSMS.SendMail(x.ToString(), "Thông báo", textBox1.Text);
                    }
                }
            }
        }
    }
}
