using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iColorServices
    {
        List<Color> GetColors();
        Color GetColorById(string id);
        Color GetColorByName(string name);

        string AddColor(Color color);

        string RemoveColor(Color color);

        string UpdateColor(Color color);
    }
}
