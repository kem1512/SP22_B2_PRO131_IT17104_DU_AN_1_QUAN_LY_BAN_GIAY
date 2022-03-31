using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.Models
{
    public class ViewInvoice
    {
        public Invoice Invoice { get; set; }

        public InvoiceDetail InvoiceDetail { get; set; }
    }
}
