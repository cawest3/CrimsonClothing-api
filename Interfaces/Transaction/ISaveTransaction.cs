using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface ISaveTransaction
    {
        void AddTransaction(Transaction newTransaction);
    }
}