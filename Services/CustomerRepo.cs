using CustomerAPI.Data;
using CustomerAPI.Interfaces;
using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly DataContext _context;
        public CustomerRepo(DataContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers() => _context.Customers.ToList();
        public Customer GetCustomerById(int id) => _context.Customers.Find(id);
        public void AddCustomer(Customer customer) {
            _context.Customers.Add(customer); 
            _context.SaveChanges(); 
        }
        public void UpdateCustomer(Customer customer) {
            _context.Customers.Update(customer); 
            _context.SaveChanges(); 
        }
        public void DeleteCustomer(int id) { 
            var customer = _context.Customers.Find(id); 
            if (customer != null) { 
                _context.Customers.Remove(customer);
                _context.SaveChanges(); 
            } 
        }
    }
}
