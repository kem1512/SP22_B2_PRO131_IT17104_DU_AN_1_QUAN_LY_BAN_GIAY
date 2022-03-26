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
    public class CategoryServices : iCategoryServices
    {
        public iDAL_Category _iDalCategory;

        public CategoryServices()
        {
            _iDalCategory = new DAL_Category();
        }
        public List<Category> GetCategories()
        {
            return _iDalCategory.GetCategories();
        }

        public Category GetCategoryById(string id)
        {
            return _iDalCategory.GetCategoryById(id);
        }

        public Category GetCategoryByName(string name)
        {
            return _iDalCategory.GetCategoryByName(name);
        }

        public string AddCategory(Category category)
        {
            return _iDalCategory.AddCategory(category);
        }

        public string RemoveCategory(Category category)
        {
            return _iDalCategory.RemoveCategory(category);
        }

        public string UpdateCategory(Category category)
        {
            return _iDalCategory.UpdateCategory(category);
        }
    }
}
