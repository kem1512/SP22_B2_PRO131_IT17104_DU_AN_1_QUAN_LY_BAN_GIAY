using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iCategoryServices
    {
        List<Category> GetCategories();
        Category GetCategoryById(string id);
        Category GetCategoryByName(string name);

        string AddCategory(Category category);

        string RemoveCategory(Category category);

        string UpdateCategory(Category category);
    }
}
