using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BussinessLayer.Models;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iInvoiceServices
    {
        string AddInvoice(Invoice invoice, List<InvoiceDetail> invoiceDetail);
        string UpdateInvoice(Invoice invoice, List<InvoiceDetail> invoiceDetail);
        string RemoveInvoice(string id);
        List<Invoice> GetInvoices();
        List<InvoiceDetail> GetInvoicesDetail();
        Invoice GetInvoiceById(string id);

        InvoiceDetail GetInvoiceDetail(string id);
    }
}
