using Assignment_1_API.Entity;
using Assignment_1_API.Interfaces;

namespace Assignment_1_API.Interfaces
{
    public interface ICustomerService
    {

        Customer GetbyId(int id);
        List<Customer> GetCustomers();
    }
}
