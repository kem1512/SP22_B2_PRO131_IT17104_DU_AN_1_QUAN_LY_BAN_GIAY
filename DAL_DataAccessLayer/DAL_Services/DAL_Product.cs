using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Product : iDAL_Product
    {
        private QuanLyBanGiayEntities _db;
        public string AddProduct(Product product, ProductDetail productDetail)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                _db.Product.Add(product); 
                _db.ProductDetail.Add(productDetail);
                return _db.SaveChanges() > 0 ? "Thêm thành công" : "Thêm thất bại";
            }
        }

        public string UpdateProduct(Product product, ProductDetail productDetail)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var pr = _db.Product.First(c => c.ProductId == product.ProductId); pr = product;
                var prd = _db.ProductDetail.First(c => c.ProductId == product.ProductId); prd = productDetail;
                return _db.SaveChanges() > 0 ? "Sửa thành công" : "Sửa thất bại";
            }
        }

        public string DeleteProduct(Product product)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                _db.Product.Remove(_db.Product.First(c => c.ProductId == product.ProductId));
                return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
            }
        }

        public List<Product> GetProduct()
        {
            using(_db = new QuanLyBanGiayEntities())
            {
                return _db.Product.ToList();
            }
        }

        public Product GetProductName(string name)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Product.First(c => c.ProductName == name);
            }
        }

        public string ChangeStatus(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var product = _db.Product.First(c => c.ProductId == id);
                product.Status = false;
                return _db.SaveChanges() > 0 ? "Xóa thành công" : "Xóa thất bại";
            }
        }
    }
}
