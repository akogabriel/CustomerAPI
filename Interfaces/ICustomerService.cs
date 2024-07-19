using CustomerAPI.Models;

namespace CustomerAPI.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(CustomerDto customerDto);
        void UpdateCustomer(CustomerDto customerDto);
        void DeleteCustomer(int id);
    }
}
