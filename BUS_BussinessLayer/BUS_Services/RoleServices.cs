﻿using System;
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
        public string AddRoles(Roles role)
        {
            return _iDal_Roles.AddRole(role);
        }

        public string UpdateRoles(Roles role)
        {
            return _iDal_Roles.UpdateRole(role);
        }

        public string RemoveRoles(Roles role)
        {
            return _iDal_Roles.RemoveRole(role);
        }

        public Roles GetRoleByID(string id)
        {
            return _iDal_Roles.GetRolesByID(id);
        }

        public List<Roles> GetListRole()
        {
            return _iDal_Roles.GetListRoles();
        }
    }
}