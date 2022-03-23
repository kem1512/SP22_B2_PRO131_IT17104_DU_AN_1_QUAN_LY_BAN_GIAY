using BUS_BussinessLayer.iBUS_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;
using DAL_DataAccessLayer.DAL_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.BUS_Services
{
    public class CategoriesServices : iCategoriesServices
    {
        private iDAL_Categories _iDAL_Categories;
        public CategoriesServices()
        {
            _iDAL_Categories = new DAL_Categories();
        }
        public List<Brand> GetBrands()
        {
            return _iDAL_Categories.GetBrands();
        }

        public List<Category> GetCategories()
        {
            return _iDAL_Categories.GetCategories();
        }

        public List<Color> GetColors()
        {
            return _iDAL_Categories.GetColors();
        }

        public List<Material> GetMaterials()
        {
            return _iDAL_Categories.GetMaterials();
        }

        public List<Size> GetSizes()
        {
            return _iDAL_Categories.GetSizes();
        }
    }
}
