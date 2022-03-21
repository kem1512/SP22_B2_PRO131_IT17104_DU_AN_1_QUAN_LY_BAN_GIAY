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
            for (int i = 0; i < 5; i++)
            {
                dgridProduct.Rows.Add(Image.FromFile(@"F:\giay.jpeg"), "Giày 1", "99.999.999 đ", "12", Image.FromFile(@"F:\shopping-cart.png"));
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            _frmMain.HackerMan();
        }
    }
}
