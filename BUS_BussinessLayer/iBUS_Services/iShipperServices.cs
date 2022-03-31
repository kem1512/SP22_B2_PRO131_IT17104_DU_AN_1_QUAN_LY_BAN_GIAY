using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iShipperServices
    {
        List<Shipper> GetListShipper();
        string AddShipper(Shipper shipper);
        string UpdateShipper(Shipper shipper);
        string RemoveShipper(string id);
        Shipper GetShipperById(string id);
    }
}
