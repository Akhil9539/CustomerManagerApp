using CustomerManagerApp.Models;

namespace CustomerManagerApp.Services
{
    public class CustomerService
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public List<Customer> GetAll() => _customers;

        public void Add(Customer customer) => _customers.Add(customer);

        public void Update(int index, Customer customer)
        {
            if (index >= 0 && index < _customers.Count)
                _customers[index] = customer;
        }
    }
}