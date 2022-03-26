using DAL_DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Category
    {
        List<Category> GetCategories();
        Category GetCategoryById(string id);
        Category GetCategoryByName(string name);

        string AddCategory(Category category);

        string RemoveCategory(Category category);

        string UpdateCategory(Category category);
    }
}
