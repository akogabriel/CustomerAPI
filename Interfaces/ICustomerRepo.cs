using CustomerAPI.Models;

namespace CustomerAPI.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
    }
}
