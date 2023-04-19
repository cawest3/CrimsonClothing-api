using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IReadCustomer
    {
        public interface IReadCustomer{
            public List<Customer> GetCustomers();

            public Customer GetCustomer(int Id);
    
        }
    }
}