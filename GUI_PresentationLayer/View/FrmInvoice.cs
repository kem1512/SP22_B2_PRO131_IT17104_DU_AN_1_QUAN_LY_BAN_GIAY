using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;

namespace GUI_PresentationLayer.View
{
    public partial class FrmInvoice : Form
    {
        private iInvoiceServices _iInvoiceServices = new InvoiceServices();
        public FrmInvoice()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgridInvoice.Rows.Clear();
            foreach (var x in _iInvoiceServices.GetInvoices())
            {
                dgridInvoice.Rows.Add(x.InvoiceId, x.DateCreate, x.CustomerId, x.EmployeeId, x.Description,
                    x.InvoiceStatus);
            }
        }

        private void dgridInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dgridInvoice.Rows[e.RowIndex];
                var result = _iInvoiceServices.GetInvoicesDetail().Where(c => c.InvoiceId == row.Cells[0].Value.ToString());
                dgidInvoiceDetail.Rows.Clear();
                foreach (var x in result)
                {
                    dgidInvoiceDetail.Rows.Add(x.ProductId, x.Price, x.Quantity, x.TotalPrice);
                }
            }
        }
    }
}
