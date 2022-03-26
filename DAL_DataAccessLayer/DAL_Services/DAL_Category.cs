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
                    _db.Category.Add(category);
                    return _db.SaveChanges() > 0 ? "Thêm thành công" : "Thêm thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveCategory(Category category)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Category.Remove(category);
                    return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
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
                    var result = GetCategoryById(category.CategoryId);
                    if (result != null)
                    {
                        result.CategoryName = category.CategoryName;
                        return _db.SaveChanges() > 0 ? "Sửa thành công" : "Sửa thất bại";
                    }

                    return "Lỗi không xác định";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
