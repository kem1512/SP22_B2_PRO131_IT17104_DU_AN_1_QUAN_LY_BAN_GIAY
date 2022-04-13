using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Customer : iDAL_Customer
    {
        private QuanLyBanGiayEntities _db;
        public List<Customer> GetCustomers()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Customer.ToList();
            }
        }

        public string AddCustomer(Customer customer)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                if (customer != null)
                {
                    _db.Customer.Add(customer);
                    _db.SaveChanges();
                    return "Thêm thành công!";
                }
                return "Thêm thất bại!";
            }
        }

        public string UpdateCustomer(Customer customer)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var cus = _db.Customer.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
                if (customer != null && cus != null)
                {
                    cus.CustomerName = customer.CustomerName;
                    cus.Address = customer.Address;
                    cus.Phone = customer.Phone;
                    cus.Status = cus.Status;
                    _db.SaveChanges();
                    return "Xóa thành công!";
                }
                return "Xóa thất bại!";
            }
        }

        public string RemoveCustomer(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var customer = _db.Customer.FirstOrDefault(c => c.CustomerId == id);
                var invoice = _db.Invoice.FirstOrDefault(c => c.CustomerId == id);
                if (id != null && customer != null)
                {
                    if (invoice != null)
                    {
                        foreach (var x in _db.InvoiceDetail.Where(c => c.InvoiceId == invoice.InvoiceId))
                        {
                            _db.InvoiceDetail.Remove(x);
                        }
                        _db.Invoice.Remove(invoice);
                    }
                    _db.Customer.Remove(customer);
                    _db.SaveChanges();
                    return "Xóa thành công!";
                }
                return "Xóa thất bại!";
            }
        }

        public Customer GetCustomerById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Customer.FirstOrDefault(c => c.CustomerId == id);
            }
        }

        public string DisableCustomer(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var customer = _db.Customer.FirstOrDefault(c => c.CustomerId == id);
                if (id != null && customer != null)
                {
                    customer.Status = false;
                    _db.SaveChanges();
                    return "Xóa thành công!";
                }
                return "Xóa thất bại!";
            }
        }

        public string RecoveryCustomer(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var customer = _db.Customer.FirstOrDefault(c => c.CustomerId == id);
                if (id != null && customer != null)
                {
                    customer.Status = true;
                    _db.SaveChanges();
                    return "Phục hồi thành công!";
                }
                return "Phục hồi thất bại!";
            }
        }

        public string IncreasePurchase(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var customer = _db.Customer.FirstOrDefault(c => c.CustomerId == id);
                if (id != null && customer != null)
                {
                    customer.ShoppingCount++;
                    _db.SaveChanges();
                    return "Thành công!";
                }
                return "Thất bại!";
            }
        }
    }
}
