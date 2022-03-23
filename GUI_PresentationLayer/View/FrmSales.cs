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
    public partial class FrmSales : Form
    {
        FrmMain _frmMain;
        public FrmSales(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            _frmMain.HackerMan();
        }
    }
}
