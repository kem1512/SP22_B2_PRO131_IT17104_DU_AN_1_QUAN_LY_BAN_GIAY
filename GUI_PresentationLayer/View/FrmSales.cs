using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.Entities;

namespace GUI_PresentationLayer.View
{
    public partial class FrmSales : Form
    {
        private FrmMain _frmMain;
        private iProductServices _iProductServices = new ProductSevices();
        private iShipperServices _iShipperServices = new ShipperServices();
        private iColorServices _iColorServices = new ColorServices();
        private iBrandServices _iBrandServices = new BrandServices();
        private iCustomerServices _iCustomerServices = new CustomerServices();
        private iInvoiceServices _iInvoiceServices = new InvoiceServices();
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        public FrmSales(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private string ValidateSale()
        {
            if (cmbPhone.SelectedIndex != -1)
            {
                return "Vui lòng nhập số điện thoại!";
            }
            if (txtAddress.Text == "")
            {
                return "Vui lòng nhập địa chỉ!";
            }
            if (txtName.Text == "")
            {
                return "Vui lòng nhập tên khách hàng!";
            }
            if (rbtnShip.Checked && txtShipCost.Text == "")
            {
                return "Vui lòng nhập giá ship!";
            }
            if (cmbShipper.SelectedIndex != -1)
            {
                return "Vui lòng chọn shipper!";
            }
            if (txtCost.Text == "")
            {
                return "Vui lòng nhập tiền khách trả!";
            }
            return null;
        }

        public string Email { get; set; }

        private void LoadData()
        {
            dgridProduct.Rows.Clear();
            var result = _iProductServices.GetViewProducts();
            foreach (var x in result.Where(c => c.product.Status))
            {
                using (FileStream fileStream = new FileStream(x.product.ProductImage, FileMode.Open))
                {
                    dgridProduct.Rows.Add(x.product.ProductId, new Bitmap(fileStream), x.product.ProductName, x.inventory.Amount, string.Format("{0:0,0}", x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Thêm");
                }
            }
            cmbColor.DataSource = _iColorServices.GetColors();
            cmbColor.DisplayMember = "ColorName";
            cmbColor.ValueMember = "ColorId";
            cmbColor.SelectedIndex = -1;

            cmbBrand.DataSource = _iBrandServices.GetBrands();
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandId";
            cmbBrand.SelectedIndex = -1;

            cmbShipper.DataSource = _iShipperServices.GetListShipper();
            cmbShipper.DisplayMember = "ShipperName";
            cmbShipper.ValueMember = "ShipperId";
            cmbShipper.SelectedIndex = -1;

            cmbPhone.DataSource = _iCustomerServices.GetCustomers();
            cmbPhone.DisplayMember = "Phone";
            cmbPhone.ValueMember = "CustomerId";
            cmbPhone.SelectedIndex = -1;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            _frmMain.HackerMan();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                var result = _iProductServices.GetViewProducts().FirstOrDefault(c =>
                    c.product.ProductId == dgridProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (result != null)
                {
                    foreach (DataGridViewRow x in dgridOrder.Rows)
                    {
                        if (x.Cells[2].Value.ToString() == result.product.ProductName)
                        {
                            x.Cells[3].Value = int.Parse(x.Cells[3].Value.ToString()) + 1;
                            x.Cells[4].Value = int.Parse(x.Cells[4].Value.ToString()) + result.productDetail.UnitPrice;
                            x.Cells[5].Value = int.Parse(x.Cells[3].Value.ToString()) * int.Parse(x.Cells[4].Value.ToString());
                            return;
                        }
                    }
                    using (FileStream fileStream = new FileStream(result.product.ProductImage, FileMode.Open))
                    {
                        dgridOrder.Rows.Add(result.product.ProductId, new Bitmap(fileStream), result.product.ProductName,
                            "1", result.productDetail.UnitPrice, result.productDetail.UnitPrice, "Xóa");
                    }
                }
            }
        }

        private void dgridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgridOrder.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dgridOrder.Rows)
            {
                x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
            }
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedIndex != -1)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrand.SelectedValue.ToString());
                }
            }
        }

        private void cmbColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedIndex != -1)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    x.Visible = x.Cells[8].Value.ToString().Equals(cmbBrand.SelectedValue.ToString());
                }
            }
        }

        private void cmbPrice_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm vào hóa đơn chờ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var invoiceId = !_iInvoiceServices.GetInvoices().Any() ? "IV1" : "IV" + _iInvoiceServices.GetInvoices().Max(c => int.Parse(c.InvoiceId.Replace("IV", "")) + 1);
                var invoice = new Invoice()
                {
                    InvoiceId = invoiceId,
                    DateCreate = DateTime.Now,
                    CustomerId = cmbPhone.SelectedValue.ToString(),
                    EmployeeId = _iEmployeeServices.GetEmployees().First().EmployeeId,
                    InvoiceStatus = false,
                };
                List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
                foreach (DataGridViewRow x in dgridOrder.Rows)
                {
                    var result = new InvoiceDetail()
                    {
                        InvoiceId = invoiceId,
                        ProductId = x.Cells[0].Value.ToString(),
                        Quantity = int.Parse(x.Cells[3].Value.ToString()),
                        Price = float.Parse(x.Cells[4].Value.ToString()),
                        TotalPrice = float.Parse(x.Cells[5].Value.ToString())
                    };
                    invoiceDetails.Add(result);
                }
                MessageBox.Show(_iInvoiceServices.AddInvoice(invoice, invoiceDetails));
            }
        }

        private void cmbPhone_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPhone.SelectedIndex != -1)
            {
                var customer = _iCustomerServices.GetCustomerById(cmbPhone.SelectedValue.ToString());
                txtName.Text = customer.CustomerName;
                txtAddress.Text = customer.Address;
            }
        }
    }
}
