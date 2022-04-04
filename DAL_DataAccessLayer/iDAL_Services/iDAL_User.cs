using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_User
    {
        List<Employee> GetUsers();
        Employee getEmployeeUserByEmail(string email);

        bool CheckEmail(string email);

        bool CheckLogin(string email, string password);
    }
}
