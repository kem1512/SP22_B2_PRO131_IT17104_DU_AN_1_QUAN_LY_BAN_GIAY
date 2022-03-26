using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PresentationLayer.View
{
    public partial class FrmProduct : Form
    {
        private iProductServices _iProductServices;
        private iCategoryServices _iCategoryServices;
        private iBrandServices _iBrandServices;
        private iMaterialServices _iMaterialServices;
        private iSizeServices _iSizeServices;
        private iColorServices _iColorServices;
        public FrmProduct()
        {
            _iProductServices = new ProductSevices();
            _iCategoryServices = new CategoryServices();
            _iBrandServices = new BrandServices();
            _iMaterialServices = new MaterialServices();
            _iSizeServices = new SizeServices();
            _iColorServices = new ColorServices();
            InitializeComponent();
        }

        private void pbxEditBrand_Click(object sender, EventArgs e)
        {
            FrmProperties frm = new FrmProperties(FrmProperties.Properties.Brand);
            frm.ShowDialog();
        }

        private void LoadData()
        {
            dgridProduct.Rows.Clear();
            var result = _iProductServices.GetViewProducts();
            foreach (var x in result.Where(c => c.product.Status))
            {
                using (FileStream fileStream = new FileStream(x.product.ProductImage, FileMode.Open))
                {
                    dgridProduct.Rows.Add(x.product.ProductImage, new Bitmap(fileStream), x.product.ProductName, x.productDetail.UnitPrice, x.inventory.Amount, "Xóa");
                }
            }

            foreach (var x in result.Where(c => c.product.Status == false))
            {
                using (FileStream fileStream = new FileStream(x.product.ProductImage, FileMode.Open))
                {
                    dgridProductDeleted.Rows.Add(x.product.ProductImage, new Bitmap(fileStream), x.product.ProductName, x.productDetail.UnitPrice, x.inventory.Amount, "Xóa");
                }
            }

            cmbBrandBot.DataSource = _iBrandServices.GetBrands();
            cmbBrandBot.DisplayMember = "BrandName";
            cmbBrandBot.ValueMember = "BrandId";
            cmbBrandBot.SelectedIndex = -1;
            
            cmbColorBot.DataSource = _iColorServices.GetColors();
            cmbColorBot.DisplayMember = "ColorName";
            cmbColorBot.ValueMember = "ColorId";
            cmbColorBot.SelectedIndex = -1;
            
            cmbMat.DataSource = _iMaterialServices.GetMaterials();
            cmbMat.DisplayMember = "MaterialName";
            cmbMat.ValueMember = "MaterialId";
            cmbMat.SelectedIndex = -1;
            
            cmbCat.DataSource = _iCategoryServices.GetCategories();
            cmbCat.DisplayMember = "CategoryName";
            cmbCat.ValueMember = "CategoryId";
            cmbCat.SelectedIndex = -1;
            
            cmbSize.DataSource = _iSizeServices.GetSizes();
            cmbSize.DisplayMember = "SizeName";
            cmbSize.ValueMember = "SizeId";
            cmbSize.SelectedIndex = -1;

            txtName.Text = "";
            txtNote.Text = "";
            txtSearch.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pbxProduct.Image == null)
            {
                MessageBox.Show("Ảnh sản phẩm không được bỏ trống");
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được bỏ trống!");
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Giá sản phẩm không được bỏ trống!");
            }
            else if (txtNote.Text == "")
            {
                MessageBox.Show("Ghi chú không được bỏ trống");
            }else if (cmbBrandBot.SelectedIndex == -1)
            {
                MessageBox.Show("Nhãn hiệu không được bỏ trống");
            }else if (cmbColorBot.SelectedIndex == -1)
            {
                MessageBox.Show("Màu sắc không được bỏ trống");
            }else if (cmbMat.SelectedIndex == -1)
            {
                MessageBox.Show("Chất liệu không được bỏ trống");
            }else if (cmbCat.SelectedIndex == -1)
            {
                MessageBox.Show("Thể loại không được bỏ trống");
            }else if (cmbSize.SelectedIndex == -1)
            {
                MessageBox.Show("Kích thước không được bỏ trống");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int productId = !_iProductServices.GetProducts().Any() ? 1 : _iProductServices.GetProducts().Max(c => int.Parse(c.ProductId.Replace("PR", "")) + 1);
                    var result = _iProductServices.AddProduct(new Product()
                    {
                        ProductId = "PR" + productId,
                        ProductName = txtName.Text,
                        ProductImage = pbxProduct.Tag.ToString(),
                        Description = txtNote.Text,
                        Status = true
                    }, new ProductDetail()
                    {
                        ProductId = "PR" + productId,
                        BrandId = cmbBrandBot.SelectedValue.ToString(),
                        ColorId = cmbColorBot.SelectedValue.ToString(),
                        MaterialId = cmbMat.SelectedValue.ToString(),
                        SizeId = cmbSize.SelectedValue.ToString(),
                        UnitPrice = float.Parse(txtPrice.Text),
                    }, new Inventory()
                    {
                        ProductId = "PR" + productId,
                        Amount = int.Parse(txtQuantity.Text)
                    });
                    MessageBox.Show(result);
                    LoadData();
                }
            }
        }

        private void pbxProduct_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    pbxProduct.Image = new Bitmap(fileStream);
                    pbxProduct.Tag = fileStream.Name;
                }
            }
        }

        private void dgridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(
                        _iProductServices.ChangeStatus(dgridProduct.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
            }
        }

        private void dgridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgridProduct.Rows[e.RowIndex];
            var product = _iProductServices.GetProducts().First(c => c.ProductId == row.Cells[0].Value.ToString());
            using (FileStream fileStream = new FileStream(product.ProductImage, FileMode.Open))
            {
                pbxProduct.Image = new Bitmap(fileStream);
                pbxProduct.Tag = fileStream.Name;
            }
            txtName.Text = row.Cells[2].Value.ToString();
            txtNote.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
            txtQuantity.Text = row.Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pbxProduct.Image == null)
            {
                MessageBox.Show("Ảnh sản phẩm không được bỏ trống");
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được bỏ trống!");
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Giá sản phẩm không được bỏ trống!");
            }
            else if (txtNote.Text == "")
            {
                MessageBox.Show("Ghi chú không được bỏ trống");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var product = _iProductServices.GetProductByName(dgridProduct.Rows[dgridProduct.CurrentRow.Index].Cells[2].Value.ToString());
                    var result = _iProductServices.UpdateProduct(new Product()
                    {
                        ProductId = product.ProductId,
                        ProductName = txtName.Text,
                        ProductImage = pbxProduct.Tag.ToString(),
                        Description = txtNote.Text,
                        Status = true
                    }, new ProductDetail()
                    {
                        ProductId = product.ProductId,
                        BrandId = cmbBrandBot.SelectedValue.ToString(),
                        ColorId = cmbColorBot.SelectedValue.ToString(),
                        MaterialId = cmbMat.SelectedValue.ToString(),
                        CategoryId = cmbCat.SelectedValue.ToString(),
                        SizeId = cmbSize.SelectedValue.ToString(),
                        UnitPrice = float.Parse(txtPrice.Text),
                    }, new Inventory()
                    {
                        ProductId = product.ProductId,
                        Amount = int.Parse(txtQuantity.Text)
                    });
                    MessageBox.Show(result);
                    LoadData();
                }
            }
        }

        private void txtQuantity_OnValueChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtQuantity.Text, "^[0-9]+$"))
            {
                txtQuantity.Text = "";
            }
        }

        private void txtPrice_OnValueChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPrice.Text, "^[0-9]+$"))
            {
                txtPrice.Text = "";
            }
        }

        private void dgridProductDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                MessageBox.Show(
                    _iProductServices.DeleteProduct(dgridProductDeleted.Rows[e.RowIndex].Cells[0].Value.ToString()));
                LoadData();
            }
        }

        private void pbxEditMat_Click(object sender, EventArgs e)
        {
            FrmProperties frmProperties = new FrmProperties(FrmProperties.Properties.Material);
            frmProperties.ShowDialog();
        }

        private void pbxEditColor_Click(object sender, EventArgs e)
        {
            FrmProperties frmProperties = new FrmProperties(FrmProperties.Properties.Color);
            frmProperties.ShowDialog();
        }

        private void pbxEditSize_Click(object sender, EventArgs e)
        {
            FrmProperties frmProperties = new FrmProperties(FrmProperties.Properties.Size);
            frmProperties.ShowDialog();
        }

        private void pbxEditCat_Click(object sender, EventArgs e)
        {
            FrmProperties frmProperties = new FrmProperties(FrmProperties.Properties.Category);
            frmProperties.ShowDialog();
        }
    }
}
