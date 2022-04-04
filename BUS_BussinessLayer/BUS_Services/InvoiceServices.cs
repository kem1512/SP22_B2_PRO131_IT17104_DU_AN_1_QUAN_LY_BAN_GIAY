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

        public List<ViewInvoice> GetViewInvoices()
        {
            // var viewInvoices = from a in _iDalInvoice.GetInvoicesDetail()
            //     group a by a.InvoiceId
            //     into b
            //     join c in _iDalInvoice.GetInvoices() on b.First().InvoiceId equals c.InvoiceId
            //     select new
            //     {
            //         ProductCount = b.Count(),
            //         TotalPrice = b.Sum(d => d.TotalPrice),
            //     };
            List<ViewInvoice> viewInvoices = (from a in _iDalInvoice.GetInvoices()
                join b in _iDalInvoice.GetInvoicesDetail() on a.InvoiceId equals b.InvoiceId
                select new ViewInvoice() {Invoice = a, InvoiceDetail = b}).ToList();
            return viewInvoices;
        }

        public string CompleteInvoice(string id)
        {
            return _iDalInvoice.CompleteInvoice(id);
        }

        public string CancelInvoice(string id, string reason)
        {
            return _iDalInvoice.CancelInvoice(id, reason);
        }
    }
}
