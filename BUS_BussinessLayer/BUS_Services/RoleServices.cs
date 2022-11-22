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
        private iDAL_Role _iDal_Role;

        public RoleServices()
        {
            _iDal_Role = new DAL_Role();
        }
        public string AddRole(Role role)
        {
            return _iDal_Role.AddRole(role);
        }

        public string UpdateRole(Role role)
        {
            return _iDal_Role.UpdateRole(role);
        }

        public string RemoveRole(string id)
        {
            return _iDal_Role.RemoveRole(id);
        }

        public Role GetRoleByID(string id)
        {
            return _iDal_Role.GetRoleById(id);
        }

        public List<Role> GetRole()
        {
            return _iDal_Role.GetRole();
        }
    }
}
