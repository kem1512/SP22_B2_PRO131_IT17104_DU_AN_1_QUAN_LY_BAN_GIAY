using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.Utilities;

namespace GUI_PresentationLayer.View
{
    public partial class SaleInvoice : Form
    {
        public SaleInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateInvoice.PrintInvoice(this);
        }
    }
}
