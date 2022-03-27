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
    public class SizeServices : iSizeServices
    {
        private iDAL_Size _dalSize;
        public SizeServices()
        {
            _dalSize = new DAL_Size();
        }
        public List<Size> GetSizes()
        {
            return _dalSize.GetSizes();
        }

        public Size GetSizeById(string id)
        {
            return _dalSize.GetSizeById(id);
        }

        public Size GetSizeByName(string name)
        {
            return _dalSize.GetSizeByName(name);
        }

        public string AddSize(Size size)
        {
            return _dalSize.AddSize(size);
        }

        public string RemoveSize(string id)
        {
            return _dalSize.RemoveSize(id);
        }

        public string UpdateSize(Size size)
        {
            return _dalSize.UpdateSize(size);
        }
    }
}
