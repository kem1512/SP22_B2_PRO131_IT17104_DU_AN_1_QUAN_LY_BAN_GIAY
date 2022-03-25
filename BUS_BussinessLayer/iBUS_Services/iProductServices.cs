using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iProductServices
    {
        string AddProduct(Product product, ProductDetail productDetail, Inventory inventory);
        string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory);
        string DeleteProduct(string id);
        string ChangeStatus(string id);
        List<Product> GetProduct();
        List<ProductDetail> GetProductDetail();
        List<Inventory> GetInventory();
        Product GetProductName(string name);

        Product GetProductId(string id);
    }
}
