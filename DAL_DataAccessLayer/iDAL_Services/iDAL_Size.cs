using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Size
    {
        List<Size> GetSizes();
        Size GetSizeById(string id);
        Size GetSizeByName(string name);

        string AddSize(Size size);

        string RemoveSize(string id);

        string UpdateSize(Size size);
    }
}
