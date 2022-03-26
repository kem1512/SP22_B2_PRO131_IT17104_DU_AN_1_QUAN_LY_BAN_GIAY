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
                return  _db.Color.FirstOrDefault(c => c.ColorId == id);
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
                    _db.Color.Add(color);
                    return _db.SaveChanges() > 0 ? "Thêm thành công" : "Thêm thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveColor(Color color)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Color.Remove(color);
                    return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
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
                // Tìm color
                var result = GetColorById(color.ColorId);
                if (result != null)
                {
                    using (_db = new QuanLyBanGiayEntities())
                    {
                        _db.Color.Remove(color);
                        return _db.SaveChanges() > 0 ? "Sửa thành công" : "Sửa thất bại";
                    }
                }
                return "Lỗi không xác định";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
