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
                if(brand != null)
                {
                    using (_db = new QuanLyBanGiayEntities())
                    {
                        _db.Brand.Add(brand);
                        _db.SaveChanges();
                        return "Thêm thành công!";
                    }
                }
                return "Thêm thất bại!";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RemoveBrand(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (id != null)
                    {
                        var brand = _db.Brand.FirstOrDefault(c => c.BrandId == id);
                        var productDetail = _db.ProductDetail.Where(c => c.BrandId == id);
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
                        if (brand != null) _db.Brand.Remove(brand);
                        _db.SaveChanges();
                        return "Xóa thành công!";
                    }
                    return "Xóa thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string UpdateBrand(Brand brand)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    // Tìm brand
                    var result = _db.Brand.FirstOrDefault(c => c.BrandId == brand.BrandId);
                    if (brand != null && result != null)
                    {
                        result.BrandName = brand.BrandName;
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
