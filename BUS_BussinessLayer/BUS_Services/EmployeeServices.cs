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
    public class EmployeeServices : iEmployeeServices
    {
        private iDAL_Employee _iDAL_Employee;
        public EmployeeServices()
        {
            _iDAL_Employee = new DAL_Employee();
        }


        public string AddEmployee(Employee employee)
        {
            return _iDAL_Employee.AddEmployee(employee);
        }

        public string UpdateEmployee(Employee employee)
        {
            return _iDAL_Employee.UpdateEmployee(employee);
        }

        public string RemoveEmployee(string id)
        {
            return _iDAL_Employee.RemoveEmployee(id);
        }

        public Employee GetEmployeeById(string id)
        {
            return _iDAL_Employee.GetEmployeeById(id);
        }

        public List<Employee> GetEmployees()
        {
            return _iDAL_Employee.GetEmployees();
        }

        public string DisableEmployee(string id)
        {
            return _iDAL_Employee.DisableEmployee(id);
        }

        public string RecoveryEmployee(string id)
        {
            return _iDAL_Employee.RecoveryEmployee(id);
        }
    }
}