using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iRoleServices
    {
        string AddRoles(Roles role);
        string UpdateRoles(Roles role);
        string RemoveRoles(Roles role);
        Roles GetRoleByID(string id);
        List<Roles> GetListRole();
    }
}
