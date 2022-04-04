using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BussinessLayer.Models;

namespace BUS_BussinessLayer.BUS_Services
{
    public class ProductSevices : iProductServices
    {
        private iDAL_Product _iDAL_Product;
        public ProductSevices()
        {
            _iDAL_Product = new DAL_Product();
        }
        public string AddProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            return _iDAL_Product.AddProduct(product, productDetail, inventory);
        }

        public string DisableProduct(string id)
        {
            return _iDAL_Product.DisableProduct(id);
        }

        public string DeleteProduct(string id)
        {
            return _iDAL_Product.DeleteProduct(id);
        }

        public string RecoveryProduct(string id)
        {
            return _iDAL_Product.RecoveryProduct(id);
        }

        public Product GetProductByName(string name)
        {
            return _iDAL_Product.GetProductByName(name);
        }

        public Product GetProductById(string id)
        {
            return _iDAL_Product.GetProductById(id);
        }

        List<Product> iProductServices.GetProducts()
        {
            return _iDAL_Product.GetProducts();
        }

        public List<ViewProduct> GetViewProducts()
        {
            List<ViewProduct> lstViewProducts = (from a in _iDAL_Product.GetProducts()
                join b in _iDAL_Product.GetProductDetail() on a.ProductId equals b.ProductId
                join c in _iDAL_Product.GetInventory() on b.ProductId equals c.ProductId
                select new ViewProduct() { product = a, productDetail = b, inventory = c}).ToList();
            return lstViewProducts;
        }

        public string ReduceProduct(string id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetail> GetProductDetails()
        {
            return _iDAL_Product.GetProductDetail();
        }

        public List<Inventory> GetInventory()
        {
            return _iDAL_Product.GetInventory();
        }

        public string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            return _iDAL_Product.UpdateProduct(product, productDetail, inventory);
        }
    }
}
