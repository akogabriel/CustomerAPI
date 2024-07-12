using CustomerAPI.Interfaces;
using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public class CustomerRepo : ICustomerRepo
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "John", LastName = "Doe" },
            new Customer { Id = 2, FirstName = "Jane", LastName = "Smith" },
        };

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }
    }
}
