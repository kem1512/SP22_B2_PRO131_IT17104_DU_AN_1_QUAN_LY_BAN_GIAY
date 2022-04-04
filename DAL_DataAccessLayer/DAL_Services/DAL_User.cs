using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;
using DAL_DataAccessLayer.iDAL_Services;

namespace DAL_DataAccessLayer.DAL_Services
{
    public class DAL_User:iDAL_User
    {
        private QuanLyBanGiayEntities _db;

        public List<Employee> GetUsers()
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Employee.ToList();
            }
        }

        public bool CheckEmail(string email)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                if (_db.Employee.Any(c => c.Email == email))
                    return true;
            }
            return false;
        }

        public bool CheckLogin(string email, string password)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                if (_db.Employee.Any(c => c.Email == email && c.Pass == password))
                    return true;
            }
            return false;
        }

        public Employee getEmployeeUserByEmail(string email)
        {
            using (_db = new QuanLyBanGiayEntities())
            {
                return _db.Employee.First(c => c.Email == email);
            }
        }
    }
}
