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
                    if (material != null)
                    {
                        _db.Material.Add(material);
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

        public string RemoveMaterial(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (id != null)
                    {
                        var material = _db.Material.FirstOrDefault(c => c.MaterialId == id);
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
                        if (material != null) _db.Material.Remove(material);
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

        public string UpdateMaterial(Material material)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var mt = _db.Material.FirstOrDefault(c => c.MaterialId == material.MaterialId);
                    if (material != null && mt != null)
                    {
                        mt.MaterialName = material.MaterialName;
                        _db.SaveChanges();
                        return "Sửa thành công!";
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
