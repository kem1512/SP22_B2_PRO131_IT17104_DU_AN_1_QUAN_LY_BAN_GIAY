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
        string AddRole(Role role);
        string UpdateRole(Role role);
        string RemoveRole(string id);
        Role GetRoleByID(string id);
        List<Role> GetRole();
    }
}
