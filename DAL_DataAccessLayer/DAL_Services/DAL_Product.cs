using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Product : iDAL_Product
    {
        private QuanLyBanGiayEntities _db;

        private static string GetFullPath()
        {
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent;
            if (directoryInfo != null)
            {
                var path = directoryInfo.FullName + @"\Images\Product\";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                return path;
            }
            return null;
        }
        public string AddProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    if (product != null && productDetail != null && inventory != null)
                    {
                        _db.Product.Add(product);
                        _db.ProductDetail.Add(productDetail);
                        _db.Inventory.Add(inventory);
                        var image = GetFullPath() + product.ProductId + Path.GetExtension(product.ProductImage);
                        if (File.Exists(image))
                        {
                            File.Delete(image);
                        }
                        if (product.ProductImage != null) File.Copy(product.ProductImage, image);
                        product.ProductImage = image;
                        _db.SaveChanges();
                        return "Thêm thành công!";
                    }
                    return "Thêm thất bại!";
                }
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        public string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    // Tìm sản phẩm cũ
                    var pr = _db.Product.FirstOrDefault(c => c.ProductId == product.ProductId);

                    // Tìm chi tiết sản phẩm cũ
                    var prd = _db.ProductDetail.FirstOrDefault(c => c.ProductId == product.ProductId);

                    // Tìm kho hàng cũ
                    var iv = _db.Inventory.FirstOrDefault(c => c.ProductId == product.ProductId);
                    if (product != null && productDetail != null && inventory != null && pr != null && prd != null && iv != null)
                    {
                        // Gán lại thuộc tính cho sản phẩm
                        pr.Description = product.Description;
                        pr.Status = product.Status;
                        pr.ProductName = product.ProductName;
                        pr.Barcode = product.Barcode;


                        //Gán lại thuộc tính cho chi tiết sản phẩm
                        prd.UnitPrice = productDetail.UnitPrice;
                        prd.CategoryId = productDetail.CategoryId;
                        prd.ColorId = productDetail.ColorId;
                        prd.MaterialId = productDetail.MaterialId;
                        prd.SizeId = productDetail.SizeId;
                        prd.BrandId = productDetail.BrandId;

                        // Gán lại số lượng
                        iv.Amount = inventory.Amount;
                        _db.SaveChanges();

                        // Tìm đường dẫn của thư mục hiện tại
                        var image = GetFullPath() + product.ProductId + Path.GetExtension(product.ProductImage);

                        if (product.ProductImage != pr.ProductImage)
                        {
                            // Xóa ảnh cũ và copy ảnh mới
                            File.Delete(pr.ProductImage);
                            if (product.ProductImage != null) File.Copy(product.ProductImage, image);
                            // Sửa lại đường dẫn ảnh
                            pr.ProductImage = image;
                        }
                        return "Sửa thành công!";
                    }
                }
                return "Sửa thất bại!";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string DeleteProduct(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    // Tìm kho hàng
                    var inventory = _db.Inventory.FirstOrDefault(c => c.ProductId == id);

                    // Tìm chi tiết sản phẩm
                    var productDetail = _db.ProductDetail.FirstOrDefault(c => c.ProductId == id);

                    // Tìm sản phẩm
                    var product = _db.Product.FirstOrDefault(c => c.ProductId == id);

                    //Tìm chi tiết hóa đơn
                    var invoiceDetail = _db.InvoiceDetail.Where(c => c.ProductId == product.ProductId).ToList();
                    if (id != null && inventory != null && productDetail != null && product != null)
                    {
                        foreach (var x in invoiceDetail)
                        {
                            var result = _db.InvoiceDetail.Where(c => c.InvoiceId == x.InvoiceId).ToList();
                            foreach (var y in result)
                            {
                                _db.InvoiceDetail.Remove(y);
                            }
                            _db.Invoice.Remove(_db.Invoice.FirstOrDefault(c => c.InvoiceId == x.InvoiceId));
                        }
                        _db.Inventory.Remove(inventory);
                        _db.ProductDetail.Remove(productDetail);
                        _db.Product.Remove(product);
                        _db.SaveChanges();
                        File.Delete(product.ProductImage);
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

        public string RecoveryProduct(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var product = _db.Product.FirstOrDefault(c => c.ProductId == id);
                    if (id != null && product != null)
                    {
                        product.Status = true;
                        _db.SaveChanges();
                        return "Phục hồi thành công!";
                    }
                    return "Phục hồi thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public List<Product> GetProducts()
        {
            using(_db = new QuanLyBanGiayEntities())
            {
                return _db.Product.ToList();
            }
        }

        public Product GetProductByName(string name)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Product.FirstOrDefault(c => c.ProductName == name);
            }
        }

        public List<ProductDetail> GetProductDetail()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.ProductDetail.ToList();
            }
        }

        public List<Inventory> GetInventory()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Inventory.ToList();
            }
        }

        public Product GetProductById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Product.FirstOrDefault(c => c.ProductId == id);
            }
        }

        public string DisableProduct(string id)
        {
            try
            {
                using (_db = new QuanLyBanGiayEntities())
                {
                    var product = _db.Product.FirstOrDefault(c => c.ProductId == id);
                    if (id != null && product != null)
                    {
                        product.Status = false;
                        _db.SaveChanges();
                        return "Sản phẩm đã được chuyển vào thùng rác!";
                    }
                    return "Xóa thất bại!";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
