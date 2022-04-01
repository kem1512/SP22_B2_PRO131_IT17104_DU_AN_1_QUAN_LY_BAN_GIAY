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
    public partial class InvoiceIcon : UserControl
    {
        public EventHandler OnSelected = null;
        public InvoiceIcon()
        {
            InitializeComponent();
        }

        public string Id
        {
            get => lblId.Text;
            set => lblId.Text = value;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OnSelected?.Invoke(this, e);
        }
    } 
}
