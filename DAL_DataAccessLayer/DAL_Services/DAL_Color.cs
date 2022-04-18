using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Color : iDAL_Color
    {
        private QuanLyBanGiayEntities _db;
        public List<Color> GetColors()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Color.ToList();
            }
        }

        public Color GetColorById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Color.First(c => c.ColorId == id);
                // return _db.Color.Find(id);
            }
        }

        public Color GetColorByName(string name)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Color.FirstOrDefault(c => c.ColorName == name);
            }
        }

        public string AddColor(Color color)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (color != null)
                    {
                        _db.Color.Add(color);
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

        public string RemoveColor(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (id != null)
                    {
                        var color = _db.Color.FirstOrDefault(c => c.ColorId == id);
                        var productDetail = _db.ProductDetail.Where(c => c.ColorId == id);
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
                        if (color != null) _db.Color.Remove(color);
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

        public string UpdateColor(Color color)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var result = _db.Color.FirstOrDefault(c => c.ColorId == color.ColorId);
                    if (color != null && result != null)
                    {
                        // Gán lại giá trị
                        result.ColorName = color.ColorName;
                        _db.SaveChanges();
                        return "Sửa thành công!";
                    }
                    return "Sửa thất bại!";
                }
                // Tìm color
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
