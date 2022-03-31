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
    public class CustomerServices : iCustomerServices
    {
        private iDAL_Customer _iDalCustomer;

        public CustomerServices()
        {
            _iDalCustomer = new DAL_Customer();
        }
        public List<Customer> GetCustomers()
        {
            return _iDalCustomer.GetCustomers();
        }

        public string AddCustomer(Customer customer)
        {
            return _iDalCustomer.AddCustomer(customer);
        }

        public string UpdateCustomer(Customer customer)
        {
            return _iDalCustomer.UpdateCustomer(customer);
        }

        public string RemoveCustomer(string id)
        {
            return _iDalCustomer.RemoveCustomer(id);
        }

        public Customer GetCustomerById(string id)
        {
            return _iDalCustomer.GetCustomerById(id);
        }

        public string DisableCustomer(string id)
        {
            return _iDalCustomer.DisableCustomer(id);
        }

        public string RecoveryCustomer(string id)
        {
            return _iDalCustomer.RecoveryCustomer(id);
        }
    }
}
