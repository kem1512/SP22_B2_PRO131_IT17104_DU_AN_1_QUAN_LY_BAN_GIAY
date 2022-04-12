using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace BUS_BussinessLayer.BUS_Services
{
    public class ShipperServices : iShipperServices
    {
        private iDAL_Shipper _iDalShipper;

        public ShipperServices()
        {
            _iDalShipper = new DAL_Shipper();
        }
        public List<Shipper> GetListShipper()
        {
            return _iDalShipper.GetListShipper();
        }

        public string AddShipper(Shipper shipper)
        {
            return _iDalShipper.AddShipper(shipper);
        }

        public string UpdateShipper(Shipper shipper)
        {
            return _iDalShipper.UpdateShipper(shipper);
        }

        public string RemoveShipper(string id)
        {
            return _iDalShipper.RemoveShipper(id);
        }

        public Shipper GetShipperById(string id)
        {
            return _iDalShipper.GetShipperById(id);
        }
    }
}
