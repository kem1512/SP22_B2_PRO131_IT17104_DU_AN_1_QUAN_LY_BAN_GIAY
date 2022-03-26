using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Material : iDAL_Material
    {
        private QuanLyBanGiayEntities _db;
        public List<Material> GetMaterials()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Material.ToList();
            }
        }

        public Material GetMaterialById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Material.FirstOrDefault(c => c.MaterialId == id);
            }
        }

        public Material GetMaterialByName(string name)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Material.FirstOrDefault(c => c.MaterialName == name);
            }
        }

        public string AddMaterial(Material material)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Material.Add(material);
                    return _db.SaveChanges() > 0 ? "Thêm thành công" : "Thêm thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveMaterial(Material material)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    _db.Material.Remove(material);
                    return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string UpdateMaterial(Material material)
        {
            try
            {
                var result = GetMaterialById(material.MaterialId);
                if (result != null)
                {
                    using (_db = new QuanLyBanGiayEntities())
                    {
                        _db.Material.Remove(material);
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
