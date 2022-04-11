using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Invoice : iDAL_Invoice
    {
        private QuanLyBanGiayEntities _db;
        public string AddInvoice(Invoice invoice, List<InvoiceDetail> invoiceDetail)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (invoice != null && invoiceDetail != null)
                    {
                        _db.Invoice.Add(invoice);
                        foreach (var x in invoiceDetail)
                        {
                            var inventory = _db.Inventory.FirstOrDefault(c => c.ProductId == x.ProductId);
                            if (inventory != null)
                            {
                                if (inventory.Amount < x.Quantity)
                                {
                                    return $"Sản phẩm {x.ProductId} không đủ hàng!";
                                }
                                inventory.Amount = inventory.Amount - x.Quantity;
                            }
                            _db.InvoiceDetail.Add(x);
                        }
                        _db.SaveChanges();
                        return "Thêm thành công!";
                    }
                    return "Thêm thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string UpdateInvoice(Invoice invoice, List<InvoiceDetail> invoiceDetail)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var inv = _db.Invoice.FirstOrDefault(c => c.InvoiceId == invoice.InvoiceId);
                    var invd = _db.InvoiceDetail.Where(c => c.InvoiceId == inv.InvoiceId).ToList();
                    if (invoice != null && invoiceDetail != null && inv != null)
                    {
                        // Sửa lại hóa đơn
                        inv.EmployeeId = invoice.EmployeeId;
                        inv.CustomerId = invoice.CustomerId;
                        inv.DateCreate = invoice.DateCreate;
                        inv.Description = invoice.Description;
                        inv.InvoiceStatus = invoice.InvoiceStatus;

                        for (int i = 0; i < invoiceDetail.Count; i++)
                        {
                            invd[i].Price = invoiceDetail[i].Price;
                            invd[i].ProductId = invoiceDetail[i].ProductId;
                            invd[i].Quantity = invoiceDetail[i].Quantity;
                            invd[i].TotalPrice = invoiceDetail[i].TotalPrice;
                        }
                        _db.SaveChanges();
                        return "Sửa thành công!";
                    }
                    return "Sửa thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string RemoveInvoice(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var invoice = _db.Invoice.FirstOrDefault(c => c.InvoiceId == id);
                    if (id != null && invoice != null)
                    {
                        foreach (var x in _db.InvoiceDetail.Where(c => c.InvoiceId == invoice.InvoiceId))
                        {
                            var inventory = _db.Inventory.FirstOrDefault(c => c.ProductId == x.ProductId);
                            if (inventory != null)
                            {
                                inventory.Amount += x.Quantity;
                            }
                            _db.InvoiceDetail.Remove(x);
                        }
                        _db.Invoice.Remove(invoice);
                        _db.SaveChanges();
                        return "Xóa thành công!";
                    }
                    return "Xóa thất bại";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<Invoice> GetInvoices()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Invoice.ToList();
            }
        }

        public List<InvoiceDetail> GetInvoicesDetail()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.InvoiceDetail.ToList();
            }
        }

        public Invoice GetInvoiceById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Invoice.FirstOrDefault(c => c.InvoiceId == id);
            }
        }

        public InvoiceDetail GetInvoiceDetail(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.InvoiceDetail.FirstOrDefault(c => c.InvoiceId == id);
            }
        }

        public string CompleteInvoice(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var invoice = _db.Invoice.FirstOrDefault(c => c.InvoiceId == id);
                    if (id != null && invoice != null)
                    {
                        invoice.InvoiceStatus = true;
                        _db.SaveChanges();
                        return "Hoàn thành đơn hàng thành công!";
                    }
                    return "Thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string CancelInvoice(string id, string reason)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var invoice = _db.Invoice.FirstOrDefault(c => c.InvoiceId == id);
                    if (invoice != null)
                    {
                        invoice.Description = reason;
                        invoice.InvoiceStatus = false;
                        var invoiceDetail = _db.InvoiceDetail.Where(c => c.InvoiceId == id);
                        foreach (var x in invoiceDetail)
                        {
                            var inventory = _db.Inventory.FirstOrDefault(c => c.ProductId == x.ProductId);
                            if (inventory != null)
                            {
                                inventory.Amount += x.Quantity;
                            }
                        }
                        _db.SaveChanges();
                        return "Hủy thành công!";
                    }
                    return "Hủy thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
