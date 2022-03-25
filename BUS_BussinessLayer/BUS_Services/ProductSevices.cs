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

namespace BUS_BussinessLayer.BUS_Services
{
    public class ProductSevices : iProductServices
    {
        private iDAL_Product iDAL_Product;
        public ProductSevices()
        {
            iDAL_Product = new DAL_Product();
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
            return iDAL_Product.AddProduct(product, productDetail, inventory);
        }

        public string ChangeStatus(string id)
        {
            return iDAL_Product.ChangeStatus(id);
        }

        public string DeleteProduct(string id)
        {
            File.Delete(iDAL_Product.GetProduct().First(c => c.ProductId == id).ProductImage);
            return iDAL_Product.DeleteProduct(id);
        }

        public List<Inventory> GetInventory()
        {
            return iDAL_Product.GetInventory();
        }

        public List<Product> GetProduct()
        {
            return iDAL_Product.GetProduct();
        }

        public List<ProductDetail> GetProductDetail()
        {
            return iDAL_Product.GetProductDetail();
        }

        public Product GetProductName(string name)
        {
            return iDAL_Product.GetProductName(name);
        }

        public Product GetProductId(string id)
        {
            return iDAL_Product.GetProductId(id);
        }

        public string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            var image = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Images\" +
                        product.ProductId + Path.GetExtension(product.ProductImage);
            var imageOld = iDAL_Product.GetProduct().First(c => c.ProductId == product.ProductId).ProductImage;
            if (product.ProductImage != imageOld)
            {
                File.Delete(imageOld);
                File.Copy(product.ProductImage, image);
            }
            return iDAL_Product.UpdateProduct(product, productDetail, inventory);
        }
    }
}
