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
                    _db.Size.Add(size);
                    return _db.SaveChanges() > 0 ? "Thêm thành công" : "Thêm thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveSize(Size size)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Size.Remove(size);
                    return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
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
                var result = GetSizeById(size.SizeId);
                if (result != null)
                {
                    using (_db = new QuanLyBanGiayEntities())
                    {
                        _db.Size.Remove(size);
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
