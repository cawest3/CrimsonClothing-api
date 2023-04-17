using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IEditTransaction
    {
        void EditTransaction(Transaction editTransaction, int Id);
    }
}