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
    public class ColorServices : iColorServices
    {
        private iDAL_Color _iDalColor;
        public ColorServices()
        {
            _iDalColor = new DAL_Color();
        }
        public List<Color> GetColors()
        {
            return _iDalColor.GetColors();
        }

        public Color GetColorById(string id)
        {
            return _iDalColor.GetColorById(id);
        }

        public Color GetColorByName(string name)
        {
            return _iDalColor.GetColorByName(name);
        }

        public string AddColor(Color color)
        {
            return _iDalColor.AddColor(color);
        }

        public string RemoveColor(Color color)
        {
            return _iDalColor.RemoveColor(color);
        }

        public string UpdateColor(Color color)
        {
            return _iDalColor.UpdateColor(color);
        }
    }
}
