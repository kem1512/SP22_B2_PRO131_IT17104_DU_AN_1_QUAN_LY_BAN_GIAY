using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_Shipper : iDAL_Shipper
    {
        private QuanLyBanGiayEntities _db;
        public List<Shipper> GetListShipper()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Shipper.ToList();
            }
        }

        public string AddShipper(Shipper shipper)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                if (shipper != null)
                {
                    _db.Shipper.Add(shipper);
                    _db.SaveChanges();
                    return "Thêm thành công!";
                }
                return "Thêm thất bại!";
            }
        }

        public string UpdateShipper(Shipper shipper)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var ship = _db.Shipper.FirstOrDefault(c => c.ShipperId == shipper.ShipperId);
                if (shipper != null && ship != null)
                {
                    ship.ShipperName = shipper.ShipperName;
                    ship.ShipperPhone = shipper.ShipperPhone;
                    ship.RoleId = shipper.RoleId;
                    ship.ShipperStatus = shipper.ShipperStatus;
                    _db.SaveChanges();
                    return "Thêm thành công!";
                }
                return "Thêm thất bại!";
            }
        }

        public string RemoveShipper(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                var shipper = _db.Shipper.FirstOrDefault(c => c.ShipperId == id);
                if (id != null && shipper != null)
                {
                    _db.Shipper.Remove(shipper);
                    _db.SaveChanges();
                    return "Thêm thành công!";
                }
                return "Thêm thất bại!";
            }
        }

        public Shipper GetShipperById(string id)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Shipper.FirstOrDefault(c => c.ShipperId == id);
            }
        }
    }
}
