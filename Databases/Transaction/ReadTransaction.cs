using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api.Databases
{
    public class ReadTransaction : IReadTransaction
    {
            public List<Transaction> GetTransactions(){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM transactions"; //help
            using var cmd = new MySqlCommand(stm, con);

            List<Transaction> Transactions = new List<Transaction>();

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read()){
                Transaction thisTransaction = new Transaction()
                {
                    transactionId = read.GetInt32(0),
                    profit = read.GetDecimal(1),
                    customerId = read.GetInt32(2),
                    itemId = read.GetInt32(3)
                };
                Transactions.Add(thisTransaction);
            }

            return Transactions; 
        
        }
    }
}