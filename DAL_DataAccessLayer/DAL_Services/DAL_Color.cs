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
                        var productDetail = _db.ProductDetail.FirstOrDefault(c => c.ColorId == id);
                        var inventory = productDetail is null ? null : _db.Inventory.FirstOrDefault(c => c.ProductId == productDetail.ProductId);
                        var product = productDetail is null ? null : _db.Product.FirstOrDefault(c => c.ProductId == productDetail.ProductId);
                        if (inventory != null) _db.Inventory.Remove(inventory);
                        if(productDetail != null) _db.ProductDetail.Remove(productDetail);
                        if(product != null) _db.Product.Remove(product);
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
