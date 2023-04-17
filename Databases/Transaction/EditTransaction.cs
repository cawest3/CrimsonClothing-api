using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class EditTransaction : IEditTransaction
    {
        void IEditTransaction.EditTransaction(Transaction editTransaction, int Id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE TRANSACTIONS SET transactionId=@transactionId, profit=@profit, customerId=@customerId, WHERE transactionId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@transactionId", editTransaction.transactionId);
            cmd.Parameters.AddWithValue("@profit", editTransaction.profit);
            cmd.Parameters.AddWithValue("@customerId", editTransaction.customerId);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }
    }
}

// int transactionId {get; set;}
// int profit {get; set;}
// int customerId {get; set;}