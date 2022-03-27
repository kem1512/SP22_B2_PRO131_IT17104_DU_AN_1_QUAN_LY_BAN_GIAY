using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BussinessLayer.Models;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iProductServices
    {
        string AddProduct(Product product, ProductDetail productDetail, Inventory inventory);
        string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory);
        string DeleteProduct(string id);
        string RecoveryProduct(string id);
        List<Product> GetProducts();
        List<Inventory> GetInventory();
        Product GetProductByName(string name);
        Product GetProductById(string id);
        string DisableProduct(string id);

        List<ViewProduct> GetViewProducts();
    }
}
