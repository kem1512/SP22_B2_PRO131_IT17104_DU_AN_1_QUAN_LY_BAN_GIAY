using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private iEmployeeServices _iEmployeeServices = new EmployeeServices();
        public FrmStatistics()
        {
            InitializeComponent();
            loadBrand();
            dgdtpcDateBegin.Value = DateTime.Now.AddMonths(-1);
            dgdtpcDateEnd.Value = DateTime.Now;
            load_Statistics(dgdtpcDateBegin.Value,dgdtpcDateEnd.Value);
            load_Cancel();
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

        void load_Statistics(DateTime from, DateTime to)
        {
            dgrid_Revenue.Rows.Clear();
            var lst = (from CTHD in _iInvoiceServices.GetInvoicesDetail()
                join HD in _iInvoiceServices.GetInvoices() on CTHD.InvoiceId equals HD.InvoiceId
                join NV in _iEmployeeServices.GetEmployees() on HD.EmployeeId equals NV.EmployeeId
                orderby HD.DateCreate
                where HD.InvoiceStatus
                select new
                {
                    HD.InvoiceId,
                    NV.EmployeeId,
                    HD.DateCreate,
                    CTHD.TotalPrice
                }).ToList();
            var stt = lst.Where(c => c.DateCreate >= from && c.DateCreate <= to);
            if (stt.Count()>0)
            {
                double total = 0;
                foreach (var x in stt)
                {
                    dgrid_Revenue.Rows.Add(x.EmployeeId, x.InvoiceId, x.DateCreate, x.TotalPrice);
                    total = stt.Select(c => c.TotalPrice).Sum();
                }

                dgrid_Revenue.Rows.Add("Tổng", null, null, string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", total));
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

        private void dgdtpcDateEnd_onValueChanged(object sender, EventArgs e)
        {
            load_Statistics(dgdtpcDateBegin.Value,dgdtpcDateEnd.Value);
            if (dgdtpcDateEnd.Value<dgdtpcDateBegin.Value)
            {
                dgdtpcDateEnd.Value=DateTime.Now;
            }
        }
        private void dgdtpcDateBegin_onValueChanged(object sender, EventArgs e)
        {
            load_Statistics(dgdtpcDateBegin.Value, dgdtpcDateEnd.Value);
        }
    }
}
