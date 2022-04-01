using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BussinessLayer.iBUS_Services;
using BUS_BussinessLayer.Models;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace BUS_BussinessLayer.BUS_Services
{
    public class InvoiceServices : iInvoiceServices
    {
        private iDAL_Invoice _iDalInvoice;
        public InvoiceServices()
        {
            _iDalInvoice = new DAL_Invoice();
        }
        public string AddInvoice(Invoice invoice, List<InvoiceDetail> invoiceDetail)
        {
            return _iDalInvoice.AddInvoice(invoice, invoiceDetail);
        }

        public string UpdateInvoice(Invoice invoice, List<InvoiceDetail> invoiceDetail)
        {
            return _iDalInvoice.UpdateInvoice(invoice, invoiceDetail);
        }

        public string RemoveInvoice(string id)
        {
            return _iDalInvoice.RemoveInvoice(id);
        }

        public List<Invoice> GetInvoices()
        {
            return _iDalInvoice.GetInvoices();
        }

        public List<InvoiceDetail> GetInvoicesDetail()
        {
            return _iDalInvoice.GetInvoicesDetail();
        }

        public Invoice GetInvoiceById(string id)
        {
            return _iDalInvoice.GetInvoiceById(id);
        }

        public InvoiceDetail GetInvoiceDetail(string id)
        {
            return _iDalInvoice.GetInvoiceDetail(id);
        }
    }
}
