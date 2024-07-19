using AutoMapper;
using CustomerAPI.Interfaces;
using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepo customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepo.GetCustomerById(id);

        }

        public void AddCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerRepo.AddCustomer(customer);
        }

        public void UpdateCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerRepo.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepo.DeleteCustomer(id);
        }
    }
}
