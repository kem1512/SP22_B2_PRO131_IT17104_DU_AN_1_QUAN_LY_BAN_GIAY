using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace DAL_DataAccessLayer.iDAL_Services
{
    public interface iDAL_Employee
    {
        string AddEmployee(Employee employee);
        string UpdateEmployee(Employee employee);
        string RemoveEmployee(string id);
        Employee GetEmployeeById(string id);
        List<Employee> GetEmployees();

        string DisableEmployee(string id);

        string RecoveryEmployee(string id);

        string ChangePassword(string email, string pass);
    }
}
