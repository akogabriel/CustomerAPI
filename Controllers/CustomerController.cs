using CustomerAPI.Interfaces;
using CustomerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        [HttpGet("GetAllCustomers")]
        public ActionResult<List<Customer>> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpGet("GetCustomerById/{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if(customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost("AddCustomer")]
        public ActionResult AddCustomer(CustomerDto customerDto)
        {
            _customerService.AddCustomer(customerDto);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customerDto.Id }, customerDto);
        }

        [HttpPut("UpdateCustomerById/{id}")]
        public ActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (id != customerDto.Id)
            {
                return BadRequest();
            }
            _customerService.UpdateCustomer(customerDto);
            return NoContent();
        }

        [HttpDelete("DeleteCustomerById/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}
