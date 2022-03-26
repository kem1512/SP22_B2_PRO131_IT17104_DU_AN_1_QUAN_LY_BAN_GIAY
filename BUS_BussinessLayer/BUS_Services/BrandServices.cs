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
    public class BrandServices : iBrandServices
    {
        private iDAL_Brand _iDalBrand;

        public BrandServices()
        {
            _iDalBrand = new DAL_Brand();
        }
        public List<Brand> GetBrands()
        {
            return _iDalBrand.GetBrands();
        }

        public Brand GetBrandById(string id)
        {
            return _iDalBrand.GetBrandById(id);
        }

        public Brand GetBrandByName(string name)
        {
            return _iDalBrand.GetBrandByName(name);
        }

        public string AddBrand(Brand brand)
        {
            return _iDalBrand.AddBrand(brand);
        }

        public string RemoveBrand(Brand brand)
        {
            return _iDalBrand.RemoveBrand(brand);
        }

        public string UpdateBrand(Brand brand)
        {
            return _iDalBrand.UpdateBrand(brand);
        }
    }
}
