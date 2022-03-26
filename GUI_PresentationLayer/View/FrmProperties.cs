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
using DAL_DataAccessLayer.Entities;

namespace GUI_PresentationLayer.View
{
    public partial class FrmProperties : Form
    {
        private iCategoryServices _iCategoryServices;
        private iBrandServices _iBrandServices;
        private iMaterialServices _iMaterialServices;
        private iSizeServices _iSizeServices;
        private iColorServices _iColorServices;
        public FrmProperties(Properties properties)
        {
            InitializeComponent();
            if (Properties.Category == properties)
            {
                _iCategoryServices = new CategoryServices();
            }else if (Properties.Brand == properties)
            {
                _iBrandServices = new BrandServices();
                LoadBrands();
            }else if (Properties.Material == properties)
            {
                _iMaterialServices = new MaterialServices();
            }else if (Properties.Size == properties)
            {
                _iSizeServices = new SizeServices();
            }else if (Properties.Color == properties)
            {
                _iColorServices = new ColorServices();
            }
        }

        private void LoadCategories()
        {
            dgridProperties.ColumnCount = 2;
            dgridProperties.Columns[0].Name = "Mã thể loại";
            dgridProperties.Columns[1].Name = "Tên thể loại";
            lblContent.Text = "Danh sách thể loại";
            lblId.Text = "Id thể loại";
            lblName.Text = "Tên thể loại";
            dgridProperties.Rows.Clear();
            foreach (var x in _iCategoryServices.GetCategories())
            {
                dgridProperties.Rows.Add(x.CategoryId, x.CategoryName);
            }
        }

        private void LoadBrands()
        {
            dgridProperties.ColumnCount = 2;
            dgridProperties.Columns[0].Name = "Mã thương hiệu";
            dgridProperties.Columns[1].Name = "Tên thương hiệu";
            lblContent.Text = "Danh sách thương hiệu";
            lblId.Text = "Mã thương hiệu";
            lblName.Text = "Tên thương hiệu";
            dgridProperties.Rows.Clear();
            foreach (var x in _iBrandServices.GetBrands())
            {
                dgridProperties.Rows.Add(x.BrandId, x.BrandName);
            }
        }

        private void LoadMaterials()
        {
            dgridProperties.ColumnCount = 2;
            dgridProperties.Columns[0].Name = "Mã chất liệu";
            dgridProperties.Columns[1].Name = "Tên chất liệu";
            dgridProperties.Rows.Clear();
            foreach (var x in _iMaterialServices.GetMaterials())
            {
                dgridProperties.Rows.Add(x.MaterialId, x.MaterialName);
            }
        }

        private void LoadSizes()
        {
            dgridProperties.ColumnCount = 2;
            dgridProperties.Columns[0].Name = "Mã kích cỡ";
            dgridProperties.Columns[0].Name = "Tên kích cỡ";
            dgridProperties.Rows.Clear();
            foreach (var x in _iSizeServices.GetSizes())
            {
                dgridProperties.Rows.Add(x.SizeId, x.SizeName);
            }
        }

        private void LoadColors()
        {
            dgridProperties.ColumnCount = 2;
            dgridProperties.Columns[0].Name = "Mã màu";
            dgridProperties.Columns[1].Name = "Tên màu";
            dgridProperties.Rows.Clear();
            foreach (var x in _iColorServices.GetColors())
            {
                dgridProperties.Rows.Add(x.ColorId, x.ColorName);
            }
        }

        public enum Properties
        {
            Category = 0, Brand = 1, Material = 2, Size = 3, Color = 4
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_iBrandServices != null)
            {
                // tìm id lớn nhất và cộng thêm 1
                int brandId = !_iBrandServices.GetBrands().Any() ? 1 : _iBrandServices.GetBrands().Max(c => int.Parse(c.BrandId.Replace("BR",""))) + 1;
                MessageBox.Show(_iBrandServices.AddBrand(new Brand()
                {
                    BrandId = "BR" + brandId,
                    BrandName = txtName.Text
                }));
                LoadBrands();
            }
        }
    }
}
