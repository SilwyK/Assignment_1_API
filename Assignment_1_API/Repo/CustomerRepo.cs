using Assignment_1_API.Entity;
using Assignment_1_API.Interfaces;
using Assignment_1_API.Service;

namespace Assignment_1_API.Repo
{
    public class CustomerRepo : ICustomerService
    {
        private List<Customer> Customers()
        {

            List<Customer> customers = new()
            {
                new Customer { Id = 1, Firstname = "Silwy", Lastname = "Khristi" },
                new Customer { Id = 2, Firstname = "Mike", Lastname = "Campbell" },
                new Customer { Id = 3, Firstname = "Michael", Lastname = "Johnson" },
                new Customer { Id = 4, Firstname = "Olwy", Lastname = "Brown" },
                new Customer { Id = 5, Firstname = "Octorina", Lastname = "Wilson" },
                new Customer { Id = 6, Firstname = "Sarah", Lastname = "Martinez" },
                new Customer { Id = 7, Firstname = "David", Lastname = "Garcia" },
                new Customer { Id = 8, Firstname = "Jessica", Lastname = "Lopez" },
                new Customer { Id = 9, Firstname = "Daniel", Lastname = "Robinson" },
                new Customer { Id = 10, Firstname = "Lisa", Lastname = "Clark" }
            };
            return customers;
        }

        public List<Customer> GetCustomers()
        {
            return Customers();
        }
        public Customer GetbyId(int id)
        {
            return Customers().FirstOrDefault(s => s.Id == id);

        }
    }

}
