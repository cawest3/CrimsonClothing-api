using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IEditCustomer
    {
        void EditCustomer(Customer editCustomer, int Id);
    }
}