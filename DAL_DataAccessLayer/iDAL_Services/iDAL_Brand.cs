using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Brand
    {
        List<Brand> GetBrands();
        Brand GetBrandById(string id);
        Brand GetBrandByName(string name);

        string AddBrand(Brand brand);

        string RemoveBrand(string brand);

        string UpdateBrand(Brand brand);
    }
}
