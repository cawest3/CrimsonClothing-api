using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IReadTransaction
    {
        public interface IReadTransaction{
            public List<Transaction> GetTransactions();

            // public Transaction GetTransaction(int Id);
    
        }
    }
}