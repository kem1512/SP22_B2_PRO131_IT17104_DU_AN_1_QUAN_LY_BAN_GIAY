using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PresentationLayer.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginTag_Click(object sender, EventArgs e)
        {

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
    }
}
