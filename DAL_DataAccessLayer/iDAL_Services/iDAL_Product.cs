﻿using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Product
    {
        string AddProduct(Product product, ProductDetail productDetail, Inventory inventory);
        string UpdateProduct(Product product, ProductDetail productDetail, Inventory inventory);
        string DeleteProduct(string id);
        string ChangeStatus(string id);
        List<Product> GetProduct();
        List<ProductDetail> GetProductDetail();
        List<Inventory> GetInventory();
        Product GetProductName(string name);
    }
}