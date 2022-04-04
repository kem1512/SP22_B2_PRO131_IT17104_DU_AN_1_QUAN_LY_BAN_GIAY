using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using ZXing;

namespace GUI_PresentationLayer.View
{
    public partial class FrmLogin : Form
    {
        FilterInfoCollection _filterInfo;
        VideoCaptureDevice _videoCaptureDevice;
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        public FrmLogin()
        {
            InitializeComponent();
            _filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in _filterInfo)
            {
                cmbCamera.Items.Add(x.Name);
                cmbCamera.SelectedIndex = 0;
            }
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            tabctrlMain.SelectedIndex = 1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tabctrlMain.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQr2_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfo[cmbCamera.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += (o, args) => pbxCamera.Image = (Bitmap) args.Frame.Clone();
            _videoCaptureDevice.Start();
            tmrScan.Start();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
                _videoCaptureDevice.Stop();
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            if (pbxCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap) pbxCamera.Image);
                if (result != null)
                {
                    var em = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == txtEmail.Text && c.Pass == txtPassword.Text);
                    if (em != null)
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.Email = em.Email;
                        Hide();
                        frmMain.Closed += (o, args) => Show();
                        frmMain.Show();
                    }
                    tmrScan.Stop();
                    if(_videoCaptureDevice.IsRunning)
                        _videoCaptureDevice.Stop();
                }
            }
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
            }else if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }else if(!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Định dạng email không đúng!");
            }
            else
            {
                var result = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == txtEmail.Text && c.Pass == txtPassword.Text);
                if (result != null)
                {
                    if (cbxRemember.Checked)
                    {
                        Properties.Settings.Default.Email = txtEmail.Text;
                        Properties.Settings.Default.Passsword = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    FrmMain frmMain = new FrmMain();
                    frmMain.Email = result.Email;
                    Hide();
                    frmMain.Closed += (o, args) => Show();
                    frmMain.Show();
                }
            }
=======
            
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email !!!");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !!!");

            }
            else if (!txtEmail.Text.Contains("@gmail") || !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!!");
            }
            else
            {
                var result = UserService.CheckLogin(txtEmail.Text, txtPassword.Text) ? true : false;
                if (result)
                {
                    this.Hide();
                    FrmMain frm = new FrmMain();
                    frm.Show();
                    LoadText();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        void LoadText()
        {
            txtEmail.Text = "Nhập email";
            txtPassword.Text = "Nhập mật khẩu";
        }

        void ChangeText()
        {
            txtEmail.Enter += (sender, args) =>
            {
                if (txtEmail.Text == "Nhập email")
                {
                    txtEmail.Text = "";
                }
            };
            txtEmail.Leave += (sender, args) =>
            {
                if (txtEmail.Text == "")
                {
                    txtEmail.Text = "Nhập email";
                }
            };

            txtPassword.Enter += (sender, args) =>
            {
                if (txtPassword.Text == "Nhập mật khẩu")
                {
                    txtPassword.Text = "";
                }
            };
            txtPassword.Leave += (sender, args) =>
            {
                if (txtPassword.Text == "")
                {
                    txtPassword.Text = "Nhập mật khẩu";
                }
            };
>>>>>>> 1b344f6adb930bf81f3fe555b4ead1d2a7b9878e
        }
    }
}
