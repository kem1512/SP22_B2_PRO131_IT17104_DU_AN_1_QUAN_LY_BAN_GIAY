using BUS_BussinessLayer.iBUS_Services;
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
    public partial class FrmProduct : Form 
    {
        private iProductServices _iProductServices;
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void pbxEditBrand_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.ShowDialog();
        }
    }
}
