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
    public class RoleServices:iRoleServices
    {
        private iDAL_Roles _iDal_Roles;

        public RoleServices()
        {
            _iDal_Roles = new DAL_Role();
        }
        public string AddRole(Roles role)
        {
            return _iDal_Roles.AddRole(role);
        }

        public string UpdateRole(Roles role)
        {
            return _iDal_Roles.UpdateRole(role);
        }

        public string RemoveRole(string id)
        {
            return _iDal_Roles.RemoveRole(id);
        }

        public Roles GetRoleByID(string id)
        {
            return _iDal_Roles.GetRoleById(id);
        }

        public List<Roles> GetRoles()
        {
            return _iDal_Roles.GetRoles();
        }
    }
}
