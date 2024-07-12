using Assignment_1_API.Entity;

namespace Assignment_1_API.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetCustomers();
    }
}
