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
                        var productDetail = _db.ProductDetail.FirstOrDefault(c => c.SizeId == id);
                        var inventory = productDetail is null ? null : _db.Inventory.FirstOrDefault(c => c.ProductId == productDetail.ProductId);
                        var product = productDetail is null ? null : _db.Product.FirstOrDefault(c => c.ProductId == productDetail.ProductId);
                        if (inventory != null) _db.Inventory.Remove(inventory);
                        if (productDetail != null) _db.ProductDetail.Remove(productDetail);
                        if (product != null) _db.Product.Remove(product);
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
