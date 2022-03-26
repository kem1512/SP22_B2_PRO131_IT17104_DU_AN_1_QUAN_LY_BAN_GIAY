using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Brand : iDAL_Brand
    {
        private QuanLyBanGiayEntities _db;
        public List<Brand> GetBrands()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return  _db.Brand.ToList();
            }
        }

        public Brand GetBrandById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Brand.FirstOrDefault(c => c.BrandId == id);
            }
        }

        public Brand GetBrandByName(string name)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Brand.FirstOrDefault(c => c.BrandName == name);
            }
        }

        public string AddBrand(Brand brand)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Brand.Add(brand);
                    return _db.SaveChanges() > 0 ? "Thêm thành công" : "Thêm thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveBrand(Brand brand)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Brand.Remove(brand);
                    return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string UpdateBrand(Brand brand)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    // Tìm brand
                    var result = GetBrandById(brand.BrandId);
                    if (result != null)
                    {
                        result.BrandName = brand.BrandName;
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
