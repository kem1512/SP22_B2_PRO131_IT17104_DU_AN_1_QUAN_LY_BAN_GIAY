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
using BUS_BussinessLayer.Utilities;
using DAL_DataAccessLayer.Entities;
using ZXing;

namespace GUI_PresentationLayer.View
{
    public partial class FrmLogin : Form
    {
        FilterInfoCollection _filterInfo;
        VideoCaptureDevice _videoCaptureDevice;
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        private string code = null;
        public FrmLogin()
        {
            InitializeComponent();
            _filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in _filterInfo)
            {
                cmbCamera.Items.Add(x.Name);
                cmbCamera.SelectedIndex = 0;
            }
            if (Properties.Settings.Default.Email != string.Empty && Properties.Settings.Default.Passsword != string.Empty)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtPassword.Text = Properties.Settings.Default.Passsword;
                cbxRemember.Checked = true;
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
            if (btnQr2.ButtonText == "Bắt đầu quét")
            {
                btnQr2.ButtonText = "Dừng quét!";
                _videoCaptureDevice = new VideoCaptureDevice(_filterInfo[cmbCamera.SelectedIndex].MonikerString);
                _videoCaptureDevice.NewFrame += (o, args) => pbxCamera.Image = (Bitmap)args.Frame.Clone();
                _videoCaptureDevice.Start();
                tmrScan.Start();
            }
            else
            {
                if (_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
                    _videoCaptureDevice.Stop();
                pbxCamera.Image = null;
                btnQr2.ButtonText = "Bắt đầu quét";
            }
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
                    string[] spearator = { ":" };
                    var em = result.ToString().Split(spearator, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (_iEmployeeServices.GetEmployees().Any(c => c.Email == em[0] && c.Pass == em[1]))
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.Email = em[0];
                        Hide();
                        frmMain.Closed += (o, args) => Show();
                        frmMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!");
                    }
                    tmrScan.Stop();
                    if(_videoCaptureDevice.IsRunning)
                        _videoCaptureDevice.Stop();
                    pbxCamera.Image = null;
                }
            }
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
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
                var result = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == txtEmail.Text && c.Pass == txtPassword.Text && c.Status);
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
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            tabctrlMain.SelectedIndex = 2;
        }

        private int countCode = 4;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtEmailForgot.Text != "")
            {
                var em = _iEmployeeServices.GetEmployees().FirstOrDefault(c => c.Email == txtEmailForgot.Text);
                if (txtCode.Text != "")
                {
                    if (txtCode.Text == code)
                    {
                        if (txtPass.Text == txtRePass.Text)
                        {
                            if (em != null)
                            {
                                MessageBox.Show(_iEmployeeServices.ChangePassword(em.Email, txtPass.Text));
                                txtEmailForgot.Text = "";
                                txtCode.Text = "";
                                txtPass.Text = "";
                                txtRePass.Text = "";
                                code = null;
                            }
                            else
                            {
                                MessageBox.Show("Nhân viên không tồn tại!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không giống nhau!");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Sai mã xác nhận, bạn còn {countCode} lần nhập!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã xác nhận!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập email");
            }
        }

        private void pbxSend_Click(object sender, EventArgs e)
        {
            if (!_iEmployeeServices.GetEmployees().Any(c => c.Email == txtEmailForgot.Text))
            {
                MessageBox.Show("Không tồn tại email!");
            }
            else if (txtEmailForgot.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn gửi mã?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    code = SendSMS.SendCode(txtEmailForgot.Text);
                    MessageBox.Show("Gửi thành công!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập email");
            }
        }
    }
}
