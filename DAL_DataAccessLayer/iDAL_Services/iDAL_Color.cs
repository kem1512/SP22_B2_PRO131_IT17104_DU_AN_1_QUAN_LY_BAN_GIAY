using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Color
    {
        List<Color> GetColors();
        Color GetColorById(string id);
        Color GetColorByName(string name);

        string AddColor(Color color);

        string RemoveColor(Color color);

        string UpdateColor(Color color);
    }
}
