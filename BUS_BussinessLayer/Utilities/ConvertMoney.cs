using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BussinessLayer.Utilities
{
    public static class ConvertMoney
    {
        public static string ConvertToVND(double money)
        {
            return string.Format("{0:0,0}", money);
        }
    }
}
