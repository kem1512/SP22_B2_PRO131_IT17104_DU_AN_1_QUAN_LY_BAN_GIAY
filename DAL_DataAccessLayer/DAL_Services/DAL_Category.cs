using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Category : iDAL_Category
    {
        private QuanLyBanGiayEntities _db;
        public List<Category> GetCategories()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Category.ToList();
            }
        }

        public Category GetCategoryById(string id)
        {

            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Category.FirstOrDefault(c => c.CategoryId == id);
            }
        }

        public Category GetCategoryByName(string name)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Category.FirstOrDefault(c => c.CategoryName == name);
            }
        }

        public string AddCategory(Category category)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (category != null)
                    {
                        _db.Category.Add(category);
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

        public string RemoveCategory(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (id != null)
                    {
                        var category = _db.Category.FirstOrDefault(c => c.CategoryId == id);
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
                        if (category != null) _db.Category.Remove(category);
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

        public string UpdateCategory(Category category)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    // Tìm category
                    var result = _db.Category.FirstOrDefault(c => c.CategoryId == category.CategoryId);
                    if (category != null && result != null)
                    {
                        result.CategoryName = category.CategoryName;
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
