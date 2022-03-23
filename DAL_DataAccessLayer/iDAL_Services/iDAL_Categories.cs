using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Categories
    {
        List<Brand> GetBrands();
        List<Color> GetColors();
        List<Material> GetMaterials();
        List<Size> GetSizes();
        List<Category> GetCategories();
    }
}
