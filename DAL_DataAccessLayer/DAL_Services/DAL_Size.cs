using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Size : iDAL_Size
    {
        private QuanLyBanGiayEntities _db;
        public List<Size> GetSizes()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Size.ToList();
            }
        }

        public Size GetSizeById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Size.FirstOrDefault(c => c.SizeId == id);
            }
        }

        public Size GetSizeByName(string name)
        {
            using(_db = new QuanLyBanGiayEntities())
            {
                return _db.Size.FirstOrDefault(c => c.SizeName == name);
            }
        }

        public string AddSize(Size size)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (size != null)
                    {
                        _db.Size.Add(size);
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

        public string RemoveSize(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (id != null)
                    {
                        var size = _db.Size.FirstOrDefault(c => c.SizeId == id);
                        var productDetail = _db.ProductDetail.Where(c => c.SizeId == id);
                        foreach (var x in productDetail)
                        {
                            var invoiceDetail = _db.InvoiceDetail.Where(c => c.ProductId == x.ProductId);
                            if (invoiceDetail.Any())
                            {
                                foreach (var y in invoiceDetail)
                                {
                                    var invoice = _db.Invoice.FirstOrDefault(c => c.InvoiceId == y.InvoiceId);
                                    if (invoice != null)
                                    {
                                        _db.Invoice.Remove(invoice);
                                    }
                                    _db.InvoiceDetail.Remove(y);
                                }
                            }
                            var product = _db.Product.FirstOrDefault(c => c.ProductId == x.ProductId);
                            var inventory = _db.Inventory.FirstOrDefault(c => c.ProductId == x.ProductId);
                            if (product != null && inventory != null)
                            {
                                _db.Product.Remove(product);
                                _db.Inventory.Remove(inventory);
                            }
                            _db.ProductDetail.Remove(x);
                        }
                        if (size != null) _db.Size.Remove(size);
                        _db.SaveChanges();
                        return "Xóa thành công!";
                    }
                    return "Xóa thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string UpdateSize(Size size)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var result = _db.Size.FirstOrDefault(c => c.SizeId == size.SizeId);
                    if (size != null && result != null)
                    {
                        result.SizeName = size.SizeName;
                        _db.SaveChanges();
                        return "Sửa thành công!";
                    }
                    return "Sửa thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
