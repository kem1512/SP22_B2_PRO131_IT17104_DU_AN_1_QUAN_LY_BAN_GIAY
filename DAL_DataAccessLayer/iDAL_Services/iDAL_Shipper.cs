using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Shipper
    {
        List<Shipper> GetListShipper();
        string AddShipper(Shipper shipper);
        string UpdateShipper(Shipper shipper);
        string RemoveShipper(string id);
        Shipper GetShipperById(string id);
    }
}
