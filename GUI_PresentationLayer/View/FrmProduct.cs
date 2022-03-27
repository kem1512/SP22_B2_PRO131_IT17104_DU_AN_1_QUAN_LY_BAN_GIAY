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
        private readonly iProductServices _iProductServices = new ProductSevices();
        private readonly iCategoryServices _iCategoryServices = new CategoryServices();
        private readonly iBrandServices _iBrandServices = new BrandServices();
        private readonly iMaterialServices _iMaterialServices = new MaterialServices();
        private readonly iSizeServices _iSizeServices = new SizeServices();
        private readonly iColorServices _iColorServices = new ColorServices();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private string ValidateForm()
        {
            if (pbxProduct.Image == null)
            {
                return "Ảnh sản phẩm không được bỏ trống";
            }
            if (txtName.Text == "")
            {
                return "Tên sản phẩm không được bỏ trống!";
            }
            if (txtQuantity.Text == "")
            {
                return "Số lượng sản phẩm không được bỏ trống!";
            }
            if (txtQuantity.Text == "0")
            {
                return "Số lượng sản phẩm không được bằng 0!";
            }
            if (txtPrice.Text == "0")
            {
                return "Giá sản phẩm không được bỏ trống!";
            }
            if (txtPrice.Text == "0")
            {
                return "Giá sản phẩm không được bằng 0!";
            }
            if (txtNote.Text == "")
            {
                return "Ghi chú không được bỏ trống";
            }
            if (cmbBrandBot.SelectedIndex == -1)
            {
                return "Nhãn hiệu không được bỏ trống";
            }
            if (cmbColorBot.SelectedIndex == -1)
            {
                return "Màu sắc không được bỏ trống";
            }
            if (cmbMat.SelectedIndex == -1)
            {
                return "Chất liệu không được bỏ trống";
            }
            if (cmbCat.SelectedIndex == -1)
            {
                return "Thể loại không được bỏ trống";
            }
            if (cmbSize.SelectedIndex == -1)
            {
                return "Kích thước không được bỏ trống";
            }
            return null;
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
                    dgridProduct.Rows.Add(x.product.ProductId, new Bitmap(fileStream), x.product.ProductName, x.inventory.Amount, string.Format("{0:0,0}", x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Xóa");
                }
            }

            dgridProductDeleted.Rows.Clear();
            foreach (var x in result.Where(c => c.product.Status == false))
            {
                using (FileStream fileStream = new FileStream(x.product.ProductImage, FileMode.Open))
                {
                    dgridProductDeleted.Rows.Add(x.product.ProductId, new Bitmap(fileStream), x.product.ProductName, x.inventory.Amount, string.Format("{0:0,0}", x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Xóa", "Phục hồi");
                }
            }

            cmbBrandTop.DataSource = _iBrandServices.GetBrands();
            cmbBrandTop.DisplayMember = "BrandName";
            cmbBrandTop.ValueMember = "BrandId";
            cmbBrandTop.SelectedIndex = -1;

            cmbColorTop.DataSource = _iColorServices.GetColors();
            cmbColorTop.DisplayMember = "ColorName";
            cmbColorTop.ValueMember = "ColorId";
            cmbColorTop.SelectedIndex = -1;

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
            pbxProduct.Image = null;

            btnEdit.Cursor = Cursors.No;
            btnAdd.Cursor = Cursors.Hand;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Cursor == Cursors.Hand)
            {
                if (ValidateForm() is null)
                {
                    var productId = !_iProductServices.GetProducts().Any() ? "PR1" : "PR" + _iProductServices.GetProducts().Max(c => int.Parse(c.ProductId.Replace("PR", "")) + 1);
                    if (MessageBox.Show("Bạn có chắc muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iProductServices.AddProduct(new Product()
                        {
                            ProductId = productId,
                            ProductName = txtName.Text,
                            ProductImage = pbxProduct.Tag.ToString(),
                            Description = txtNote.Text,
                            Status = true
                        }, new ProductDetail()
                        {
                            ProductId = productId,
                            BrandId = cmbBrandBot.SelectedValue.ToString(),
                            ColorId = cmbColorBot.SelectedValue.ToString(),
                            MaterialId = cmbMat.SelectedValue.ToString(),
                            SizeId = cmbSize.SelectedValue.ToString(),
                            CategoryId = cmbCat.SelectedValue.ToString(),
                            UnitPrice = float.Parse(txtPrice.Text),
                        }, new Inventory()
                        {
                            ProductId = productId,
                            Amount = int.Parse(txtQuantity.Text)
                        }));
                    }
                }
                else
                {
                    MessageBox.Show(ValidateForm());
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
            if (e.ColumnIndex == 11)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iProductServices.DisableProduct(dgridProduct.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
            }
        }

        private void dgridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnEdit.Cursor = Cursors.Hand;
                btnAdd.Cursor = Cursors.No;
                var row = dgridProduct.Rows[e.RowIndex];
                var product = _iProductServices.GetProductById(row.Cells[0].Value.ToString());
                using (FileStream fileStream = new FileStream(product.ProductImage, FileMode.Open))
                {
                    pbxProduct.Image = new Bitmap(fileStream);
                    pbxProduct.Tag = fileStream.Name;
                }
                txtName.Text = row.Cells[2].Value.ToString();
                txtNote.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtNote.Text = row.Cells[5].Value.ToString();
                cmbBrandBot.SelectedValue = row.Cells[6].Value.ToString();
                cmbMat.SelectedValue = row.Cells[7].Value.ToString();
                cmbColorBot.SelectedValue = row.Cells[8].Value.ToString();
                cmbSize.SelectedValue = row.Cells[9].Value.ToString();
                cmbCat.SelectedValue = row.Cells[10].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Cursor == Cursors.Hand)
            {
                if (dgridProduct.CurrentRow != null && ValidateForm() is null)
                {
                    var id = dgridProduct.Rows[dgridProduct.CurrentRow.Index].Cells[0].Value.ToString();
                    var product = new Product()
                    {
                        ProductId = id,
                        ProductName = txtName.Text,
                        ProductImage = pbxProduct.Tag.ToString(),
                        Description = txtNote.Text,
                        Status = true
                    };
                    var productDetail = new ProductDetail()
                    {
                        ProductId = id,
                        BrandId = cmbBrandBot.SelectedValue.ToString(),
                        ColorId = cmbColorBot.SelectedValue.ToString(),
                        MaterialId = cmbMat.SelectedValue.ToString(),
                        CategoryId = cmbCat.SelectedValue.ToString(),
                        SizeId = cmbSize.SelectedValue.ToString(),
                        UnitPrice = float.Parse(txtPrice.Text)
                    };
                    var inventoty = new Inventory()
                    {
                        ProductId = id,
                        Amount = int.Parse(txtQuantity.Text)
                    };
                    if (MessageBox.Show("Bạn có chắc muốn sửa không", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iProductServices.UpdateProduct(product, productDetail, inventoty));
                    }
                }
                else
                {
                    MessageBox.Show(ValidateForm());
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
            if (e.ColumnIndex == 11)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iProductServices.DeleteProduct(dgridProductDeleted.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
            }
            if (e.ColumnIndex == 12)
            {
                if (MessageBox.Show("Bạn có chắc muốn phục hồi không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iProductServices.RecoveryProduct(dgridProductDeleted.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    LoadData();
                }
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

        private void FrmProduct_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            if (tabProduct.Visible)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
                }
            }
            else
            {
                foreach (DataGridViewRow x in dgridProductDeleted.Rows)
                {
                    x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
                }
            }
        }

        private void cmbBrandTop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrandTop.SelectedIndex != -1)
            {
                if (tabProduct.Visible)
                {
                    foreach (DataGridViewRow x in dgridProduct.Rows)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString());
                    }
                }
                else
                {
                    foreach (DataGridViewRow x in dgridProductDeleted.Rows)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString());
                    }
                }
            }
        }

        private void cmbColorTop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrandTop.SelectedIndex != -1)
            {
                if (tabProduct.Visible)
                {
                    foreach (DataGridViewRow x in dgridProduct.Rows)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }
                }
                else
                {
                    foreach (DataGridViewRow x in dgridProductDeleted.Rows)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }
                }
            }
        }
    }
}
