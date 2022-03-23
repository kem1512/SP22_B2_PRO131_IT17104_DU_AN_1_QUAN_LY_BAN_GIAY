using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iCategoriesServices
    {
        List<Brand> GetBrands();
        List<Color> GetColors();
        List<Material> GetMaterials();
        List<Size> GetSizes();
        List<Category> GetCategories();
    }
}
