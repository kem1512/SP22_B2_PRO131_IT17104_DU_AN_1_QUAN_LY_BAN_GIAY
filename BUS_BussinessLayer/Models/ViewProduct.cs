using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.iDAL_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.Models
{
    public class ViewProduct
    {
        public Product product { get; set; }
        public ProductDetail productDetail { get; set; }
        public Inventory inventory { get; set; }
    }
}
