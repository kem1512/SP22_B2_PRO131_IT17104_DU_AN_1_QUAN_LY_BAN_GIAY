using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Roles
    {
        string AddRole(Roles role);
        string UpdateRole(Roles role);
        string RemoveRole(Roles role);
        Roles GetRolesByID(string id);
        List<Roles> GetListRoles();
    }
}
