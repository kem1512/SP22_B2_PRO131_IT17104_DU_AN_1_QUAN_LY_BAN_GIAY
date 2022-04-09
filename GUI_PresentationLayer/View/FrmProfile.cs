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
using FontAwesome.Sharp;

namespace GUI_PresentationLayer.View
{
    public partial class FrmProfile : Form
    {
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        private string email; 
        public FrmProfile(string email)
        {
            InitializeComponent();
            this.email = email;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbxUser.Width - 6, pbxUser.Height - 6);
            pbxUser.Region = new Region(gp);
        }

        public string Email
        {
            get => email; 
            set => email = value;
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            if (email != null)
            {
                var em = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == email);
                if (em != null)
                {
                    txtEmail.Text = em.Email;
                    txtName.Text = em.FullName;
                    txtPassword.Text = em.Pass;
                    txtPhone.Text = em.Phone;
                    txtAddress.Text = em.Address;
                    if (em.Gender)
                    {
                        rbxMale.Checked = true;
                    }
                    else
                    {
                        rbxFemale.Checked = true;
                    }

                    if (File.Exists(em.EmployeeImage))
                    {
                        using (FileStream fileStream = new FileStream(em.EmployeeImage, FileMode.Open))
                        {
                            pbxUser.Image = new Bitmap(fileStream);
                        }
                    }
                    else
                    {
                        pbxUser.Image = Properties.Resources.failed;
                    }
                }
            }
        }

        private void pbxPass_Click(object sender, EventArgs e)
        {
            if (pbxPass.IconChar == IconChar.Eye)
            {
                txtPassword.UseSystemPasswordChar = false;
                pbxPass.IconChar = IconChar.EyeSlash;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pbxPass.IconChar = IconChar.Eye;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn gửi lại mã QR","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var em = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == email);
                var image = GenerateCode.CreateQRCode(em.Email, em.Pass);
                SendSMS.SendMailQr(em.Email, "Gửi lại  mã QR", "Nè", image);
            }
        }
    }
}
