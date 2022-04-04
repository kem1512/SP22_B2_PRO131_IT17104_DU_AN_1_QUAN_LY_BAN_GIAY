using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer.Entities;

namespace BUS_BussinessLayer.iBUS_Services
{
    public interface iCustomerServices
    {
        List<Customer> GetCustomers();

        string AddCustomer(Customer customer);

        string UpdateCustomer(Customer customer);

        string RemoveCustomer(string id);

        Customer GetCustomerById(string id);

        string DisableCustomer(string id);

        string RecoveryCustomer(string id);

        string IncreasePurchase(string id);
    }
}
