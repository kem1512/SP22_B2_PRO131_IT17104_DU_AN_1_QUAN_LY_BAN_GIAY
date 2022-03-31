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
        string AddRole(Roles role);
        string UpdateRole(Roles role);
        string RemoveRole(string id);
        Roles GetRoleByID(string id);
        List<Roles> GetRoles();
    }
}
