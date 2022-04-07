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
    public partial class FrmStatistics : Form
    {
        private iInvoiceServices _iInvoiceServices=new InvoiceServices();
        private iProductServices _iProductServices = new ProductSevices();
        private iBrandServices _iBrandServices = new BrandServices();
        private iCustomerServices _iCustomerServices = new CustomerServices();
        public FrmStatistics()
        {
            InitializeComponent();
            loadBrand();
        }

        void load_BrandSelled(string brand)
        {
            var lst = (from HD in _iInvoiceServices.GetInvoices()
                join CTHD in _iInvoiceServices.GetInvoicesDetail() on HD.InvoiceId equals CTHD.InvoiceId
                join DT in _iProductServices.GetProductDetail() on CTHD.ProductId equals DT.ProductId
                join SP in _iProductServices.GetProducts() on DT.ProductId equals SP.ProductId
                join BRD in _iBrandServices.GetBrands() on DT.BrandId equals BRD.BrandId
                where HD.InvoiceStatus && BRD.BrandName == brand
                select new
                {
                    HD.InvoiceId,
                    SP.ProductName,
                    CTHD.Quantity
                }).ToList();
            dgrid_Brand.Rows.Clear();
            if (lst.Count>0)
            {
                int soluong = 0;
                foreach (var i in lst)
                {
                    dgrid_Brand.Rows.Add(i.InvoiceId, i.ProductName, i.Quantity);
                    soluong = lst.Select(c => c.Quantity).Sum();
                }
                dgrid_Brand.Rows.Add("Tổng", null, soluong);
            }
        }

        void load_Cancel()
        {
            var lst = (from KH in _iCustomerServices.GetCustomers()
                join HD in _iInvoiceServices.GetInvoices() on KH.CustomerId equals HD.CustomerId
                join CTHD in _iInvoiceServices.GetInvoicesDetail() on HD.InvoiceId equals CTHD.InvoiceId
                where HD.InvoiceStatus == false
                select new
                {
                    HD.InvoiceId,
                    KH.CustomerName,
                    KH.Phone,
                    HD.Description,
                    CTHD.TotalPrice
                }).ToList();
            dgrid_Cancel.Rows.Clear();
            if (lst.Count>0)
            {
                foreach (var x in lst)
                {
                    dgrid_Cancel.Rows.Add(x.InvoiceId, x.CustomerName, x.Phone, x.Description, x.TotalPrice);
                }
            }
        }
        void loadBrand()
        {
            cmbFilter.DataSource = _iBrandServices.GetBrands();
            cmbFilter.DisplayMember = "BrandName";
            cmbFilter.ValueMember = "BrandName";
            cmbFilter.SelectedIndex = -1;
        }

        private void cmbFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex!=-1)
            {
                load_BrandSelled(cmbFilter.SelectedValue.ToString());
            }
        }
    }
}
