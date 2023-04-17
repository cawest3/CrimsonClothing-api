using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface ISaveCustomer
    {
        void AddCustomer(Customer newCustomer);
    }
}