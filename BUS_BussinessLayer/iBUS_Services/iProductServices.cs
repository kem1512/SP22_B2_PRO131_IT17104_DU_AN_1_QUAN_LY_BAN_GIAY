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
        string AddProduct(Product product, ProductDetail productDetail);
        string UpdateProduct(Product product, ProductDetail productDetail);
        string DeleteProduct(Product product);
        string ChangeStatus(string id);
        List<Product> GetProduct();
        Product GetProductName(string name);
    }
}
