using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class SaveTransaction : ISaveTransaction
    {
        public void AddTransaction(Transaction newTransaction)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO transactions(transactionId, profit, customerId) VALUES(@transactionId, @profit, @customerId)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@transactionId", newTransaction.transactionId);
            cmd.Parameters.AddWithValue("@profit", newTransaction.profit);
            cmd.Parameters.AddWithValue("@customerId", newTransaction.customerId);

            cmd.ExecuteNonQuery();
        }
    }
}


// int transactionId {get; set;}
// int profit {get; set;}
// int customerId {get; set;}