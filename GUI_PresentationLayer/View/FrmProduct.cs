using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BussinessLayer.Models;
using BUS_BussinessLayer.Utilities;
using Microsoft.Office.Interop.Excel;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
// using Syncfusion.Pdf;
// using Syncfusion.Pdf.Graphics;
// using Syncfusion.Pdf.Tables;
using Color = System.Drawing.Color;
using DataGridViewCell = System.Windows.Forms.DataGridViewCell;
using DataTable = System.Data.DataTable;
// using PdfPage = Syncfusion.Pdf.PdfPage;

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
            if (txtBarcode.Text == "")
            {
                return "Mã vạch không được bỏ trống";
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
            var products = _iProductServices.GetViewProducts();
            foreach (var x in products.Where(c => c.product.Status))
            {
                if (File.Exists(x.product.ProductImage))
                {
                    using (FileStream fileStream = new FileStream(x.product.ProductImage, FileMode.Open))
                    {
                        dgridProduct.Rows.Add(x.product.ProductId, new Bitmap(fileStream), x.product.ProductName, x.inventory.Amount, ConvertMoney.ConvertToVND(x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Xóa", x.inventory.Amount <= 0 ? "Đã hết hàng" : x.inventory.Amount < 10 ? "Sắp hết hàng" : "Còn hàng");
                    }
                }
                else
                {
                    dgridProduct.Rows.Add(x.product.ProductId, Properties.Resources.failed, x.product.ProductName, x.inventory.Amount, ConvertMoney.ConvertToVND(x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Xóa", x.inventory.Amount <= 0 ? "Đã hết hàng" : x.inventory.Amount < 10 ? "Sắp hết hàng" : "Còn hàng");
                }
            }

            dgridProductDeleted.Rows.Clear();
            foreach (var x in products.Where(c => c.product.Status == false))
            {
                if (File.Exists(x.product.ProductImage))
                {
                    using (FileStream fileStream = new FileStream(x.product.ProductImage, FileMode.Open))
                    {
                        dgridProductDeleted.Rows.Add(x.product.ProductId, new Bitmap(fileStream), x.product.ProductName, x.inventory.Amount, ConvertMoney.ConvertToVND(x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Xóa", "Phục hồi");
                    }
                }
                else
                {
                    dgridProductDeleted.Rows.Add(x.product.ProductId, Properties.Resources.failed, x.product.ProductName, x.inventory.Amount, ConvertMoney.ConvertToVND(x.productDetail.UnitPrice), x.product.Description, x.productDetail.BrandId, x.productDetail.MaterialId, x.productDetail.ColorId, x.productDetail.SizeId, x.productDetail.CategoryId, "Xóa", "Phục hồi");
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

            txtBarcode.Items.Clear();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm() is null)
            {
                if (_iProductServices.GetProducts().Any(c => c.ProductName == txtName.Text))
                {
                    MessageBox.Show("Đã tồn tại sản phẩm!");
                }
                else
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
                            Status = true,
                            Barcode = txtBarcode.SelectedItem.ToString()
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
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show(ValidateForm());
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
                var row = dgridProduct.Rows[e.RowIndex];
                var product = _iProductServices.GetProductById(row.Cells[0].Value.ToString());
                if (File.Exists(product.ProductImage))
                {
                    using (FileStream fileStream = new FileStream(product.ProductImage, FileMode.Open))
                    {
                        pbxProduct.Image = new Bitmap(fileStream);
                        pbxProduct.Tag = fileStream.Name;
                    }
                }
                else
                {
                    pbxProduct.Image = Properties.Resources.failed;
                    pbxProduct.Tag = product.ProductImage;
                }
                txtName.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtNote.Text = row.Cells[5].Value.ToString();
                cmbBrandBot.SelectedValue = row.Cells[6].Value.ToString();
                cmbMat.SelectedValue = row.Cells[7].Value.ToString();
                cmbColorBot.SelectedValue = row.Cells[8].Value.ToString();
                cmbSize.SelectedValue = row.Cells[9].Value.ToString();
                cmbCat.SelectedValue = row.Cells[10].Value.ToString();

                txtBarcode.Items.Clear();
                txtBarcode.Items.Add(product.Barcode);
                txtBarcode.SelectedItem = product.Barcode;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    Barcode = txtBarcode.Text,
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
                    LoadData();
                }
            }
            else
            {
                    MessageBox.Show(ValidateForm());
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
            if (!Regex.IsMatch(txtPrice.Text, "^[0-9.]+$"))
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
            foreach (DataGridViewRow x in dgridProduct.Rows)
            {
                if (cmbBrandTop.SelectedIndex != -1 && cmbColorTop.SelectedIndex != -1 && cmbStatus.SelectedIndex != -1)
                {
                    if(x.Visible) x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
                }
                else
                {
                    x.Visible = x.Cells[2].Value.ToString().Contains(txtSearch.Text);
                }
            }
        }

        private void cmbBrandTop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrandTop.SelectedIndex != -1)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    if (cmbColorTop.SelectedIndex != -1 && cmbStatus.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else if (cmbColorTop.SelectedIndex != -1 && cmbStatus.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }else if (cmbStatus.SelectedIndex != -1 && cmbColorTop.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString());
                    }
                }
            }
        }

        private void cmbColorTop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbColorTop.SelectedIndex != -1)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    if (cmbBrandTop.SelectedIndex != -1 && cmbStatus.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else if (cmbBrandTop.SelectedIndex != -1 && cmbStatus.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }
                    else if (cmbStatus.SelectedIndex != -1 && cmbBrandTop.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }
                }
            }
        }

        private string RandomBarcode()
        {
            try
            {
                const string valid = "0123456789";
                StringBuilder stringBuilder = new StringBuilder();
                Random random = new Random();
                int a = 13;
                while (0 < a--)
                {
                    stringBuilder.Append(valid[random.Next(valid.Length)]);
                }
                return stringBuilder.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfDocument pdfDocument = new PdfDocument();
                PdfPage pdfPage = pdfDocument.Pages.Add();
                // set lề là 0
                pdfDocument.PageSettings.SetMargins(0);
                var number = 0;
                for (int i = 0; i < dgridProduct.Rows.Count; i++)
                {
                    if ((i + 1) % 4 == 0)
                    {
                        pdfPage = pdfDocument.Pages.Add();
                        number = 0;
                    }
                    // tìm sản phẩm trong csdl
                    var result = _iProductServices.GetProductById(dgridProduct.Rows[i].Cells[0].Value.ToString());
            
                    // tạo mã vạch
                    var image = GenerateCode.CreateBarcode(result.Barcode);
            
                    // tạo đối tượng để lưu ảnh
                    PdfBitmap pdfBitmap = new PdfBitmap(image);
            
                    // set phông chữ
                    PdfFont pdfFont = new PdfTrueTypeFont(@"C:\Users\kem15\Downloads\QuanLyBanGiay\Font\FontBarcode.ttf", 18);
            
                    // set vị trí của chữ
                    PdfStringFormat pdfStringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            
                    // tạo khung cho sản thông tin sản phẩm
                    RectangleF rectangleInfo = new RectangleF(new PointF(0, (100 + 40 + 110) * number), new SizeF(pdfPage.Size.Width, 50));
            
                    RectangleF rectangleBarcode = new RectangleF(new PointF((pdfDocument.PageSettings.Width - 200) / 2 , rectangleInfo.Bottom), new SizeF(200, 100));
            
                    // tạo khung cho số mã vạch
                    RectangleF rectangleBarNumber = new RectangleF(new PointF(0, rectangleBarcode.Bottom), new SizeF(pdfDocument.PageSettings.Width, 40));
                    PdfGraphics pdfGraphics = pdfPage.Graphics;
                    pdfGraphics.DrawString($"{result.ProductId} : {result.ProductName}", pdfFont, new PdfPen(Color.Red), rectangleInfo, pdfStringFormat);
                    pdfGraphics.DrawImage(pdfBitmap, rectangleBarcode);
                    pdfGraphics.DrawString(result.Barcode, pdfFont, new PdfPen(Color.Black), rectangleBarNumber, pdfStringFormat);
                    number++;
                }
                pdfDocument.Save(saveFileDialog.FileName);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GenerateDoucument.ToExcel(dgridProduct, saveFileDialog.FileName);
            }
        }

        private void pbxRandom_Click(object sender, EventArgs e)
        {
            var random = RandomBarcode();
            txtBarcode.Items.Clear();
            txtBarcode.Items.Add(random);
            txtBarcode.SelectedItem = random;
        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPrice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex != -1)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    if (cmbBrandTop.SelectedIndex != -1 && cmbColorTop.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else if (cmbBrandTop.SelectedIndex != -1 && cmbColorTop.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else if (cmbColorTop.SelectedIndex != -1 && cmbBrandTop.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else
                    {
                        x.Visible = x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                }
            }
        }

        private void cmbBrandTop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    if (cmbColorTop.SelectedIndex != -1 && cmbBrandTop.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString());
                    }
                    else if (cmbColorTop.SelectedIndex != -1 && cmbBrandTop.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }
                    else if (cmbBrandTop.SelectedIndex != -1 && cmbColorTop.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedItem.ToString());
                    }
                    else
                    {
                        if (!x.Visible) x.Visible = true;
                    }
                }
                cmbStatus.SelectedIndex = -1;
            }
        }

        private void cmbBrandTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    if (cmbColorTop.SelectedIndex != -1 && cmbStatus.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else if (cmbColorTop.SelectedIndex != -1 && cmbStatus.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[8].Value.ToString().Equals(cmbColorTop.SelectedValue.ToString());
                    }
                    else if (cmbStatus.SelectedIndex != -1 && cmbColorTop.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else
                    {
                        if (!x.Visible) x.Visible = true;
                    }
                }
                cmbBrandTop.SelectedIndex = -1;
            }
        }

        private void cmbColorTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (DataGridViewRow x in dgridProduct.Rows)
                {
                    if (cmbBrandTop.SelectedIndex != -1 && cmbStatus.SelectedIndex != -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString()) && x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else if (cmbBrandTop.SelectedIndex != -1 && cmbStatus.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[6].Value.ToString().Equals(cmbBrandTop.SelectedValue.ToString());
                    }
                    else if (cmbStatus.SelectedIndex != -1 && cmbColorTop.SelectedIndex == -1)
                    {
                        x.Visible = x.Cells[12].Value.ToString().Equals(cmbStatus.SelectedItem.ToString());
                    }
                    else
                    {
                        if (!x.Visible) x.Visible = true;
                    }
                }
                cmbColorTop.SelectedIndex = -1;
            }
        }
    }
}
