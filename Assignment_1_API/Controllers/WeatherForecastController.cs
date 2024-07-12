using Assignment_1_API.Entity;
using Assignment_1_API.Interfaces;
using Assignment_1_API.Repo;
using Assignment_1_API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public WeatherForecastController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            return Ok(customerService.GetCustomers());
        }
        [HttpGet("GetCustomerById/{id}")]
        public IActionResult GetAllCustomers(int id)
        {
            return Ok(customerService.GetbyId(id));
        }
    }
}
