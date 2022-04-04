using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.DAL_Services;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace BUS_BussinessLayer.BUS_Services
{
    public static class UserService
    {
        private static iDAL_User _User;

        static UserService()
        {
            _User = new DAL_User();
        }
        public static List<Employee> GetUsers()
        {
            return _User.GetUsers();
        }
        public static bool CheckEmail(string email)
        {
            return _User.CheckEmail(email);
        }

        public static bool CheckLogin(string email, string password)
        {
            return _User.CheckLogin(email, password);
        }

        public static Employee getEmployeeUserByEmail(string email)
        {
            return _User.getEmployeeUserByEmail(email);
        }
    }
}
