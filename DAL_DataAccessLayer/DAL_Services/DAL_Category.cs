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
                        var productDetail = _db.ProductDetail.FirstOrDefault(c => c.SizeId == id);
                        var inventory = productDetail is null ? null : _db.Inventory.FirstOrDefault(c => c.ProductId == productDetail.ProductId);
                        var product = productDetail is null ? null : _db.Product.FirstOrDefault(c => c.ProductId == productDetail.ProductId);
                        if (inventory != null) _db.Inventory.Remove(inventory);
                        if (productDetail != null) _db.ProductDetail.Remove(productDetail);
                        if (product != null) _db.Product.Remove(product);
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
