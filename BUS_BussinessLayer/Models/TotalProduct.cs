using BUS_BussinessLayer.BUS_Services;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.iDAL_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.Models
{
    static public class TotalProduct
    {
        static private iDAL_Product _iDAL_Product;

        static TotalProduct()
        {
            _iDAL_Product = new DAL_Product();
        }
    }
}
