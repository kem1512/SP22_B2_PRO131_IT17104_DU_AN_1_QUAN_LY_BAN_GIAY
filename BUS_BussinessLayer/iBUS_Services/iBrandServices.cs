using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iBrandServices
    {
        List<Brand> GetBrands();
        Brand GetBrandById(string id);
        Brand GetBrandByName(string name);

        string AddBrand(Brand brand);

        string RemoveBrand(string id);

        string UpdateBrand(Brand brand);
    }
}
