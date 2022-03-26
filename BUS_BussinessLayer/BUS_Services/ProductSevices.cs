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
        private List<ViewProduct> _lstViewProducts;
        public ProductSevices()
        {
            _lstViewProducts = new List<ViewProduct>();
            _iDAL_Product = new DAL_Product();
        }

        public string GetFullPath()
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Images\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
        public string AddProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            var image = GetFullPath() + product.ProductId + Path.GetExtension(product.ProductImage);
            if (File.Exists(image))
            {
                File.Delete(image);
            }
            File.Copy(product.ProductImage, image);
            product.ProductImage = image;
            return _iDAL_Product.AddProduct(product, productDetail, inventory);
        }

        public string ChangeStatus(string id)
        {
            return _iDAL_Product.ChangeStatus(id);
        }

        public string DeleteProduct(string id)
        {
            File.Delete(_iDAL_Product.GetProducts().First(c => c.ProductId == id).ProductImage);
            return _iDAL_Product.DeleteProduct(id);
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
            _lstViewProducts = (from a in _iDAL_Product.GetProducts()
                join b in _iDAL_Product.GetProductDetail() on a.ProductId equals b.ProductId
                join c in _iDAL_Product.GetInventory() on b.ProductId equals c.ProductId
                select new ViewProduct() { product = a, productDetail = b, inventory = c}).ToList();
            return _lstViewProducts;
        }

        public string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            var image = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Images\" +
                        product.ProductId + Path.GetExtension(product.ProductImage);
            var imageOld = _iDAL_Product.GetProducts().First(c => c.ProductId == product.ProductId).ProductImage;
            if (product.ProductImage != imageOld)
            {
                File.Delete(imageOld);
                File.Copy(product.ProductImage, image);
            }
            return _iDAL_Product.UpdateProduct(product, productDetail, inventory);
        }
    }
}
