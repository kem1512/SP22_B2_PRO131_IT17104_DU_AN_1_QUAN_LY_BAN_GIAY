using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;

namespace GUI_PresentationLayer.View
{
    public partial class FrmLogin : Form
    {
        FilterInfoCollection _filterInfo;
        VideoCaptureDevice _videoCaptureDevice;
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
                    MessageBox.Show(result.ToString());
                    tmrScan.Stop();
                    if(_videoCaptureDevice.IsRunning)
                        _videoCaptureDevice.Stop();
                }
            }
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            Hide();
            frmMain.Closed += (o, args) => Close();
            frmMain.Show();
        }
    }
}
