using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Role
    {
        string AddRole(Role role);
        string UpdateRole(Role role);
        string RemoveRole(string id);
        Role GetRoleById(string id);
        List<Role> GetRole();
    }
}
