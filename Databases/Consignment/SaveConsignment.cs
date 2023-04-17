using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class SaveConsignment : ISaveConsignment
    {
        public void AddConsignment(Consignment newConsignment)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO CONSIGNMENTS(consignmentId, customerId, price, cost, profit) VALUES(@consignmentId, @customerId, @price, @cost, @profit)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@consignmentId", newConsignment.consignmentId);
            cmd.Parameters.AddWithValue("@customerId", newConsignment.customerId);
            cmd.Parameters.AddWithValue("@price", newConsignment.price);
            cmd.Parameters.AddWithValue("@cost", newConsignment.cost);
            cmd.Parameters.AddWithValue("@profit", newConsignment.profit);

            cmd.ExecuteNonQuery();
        }
    }




    //     int consignmentId {get; set;}

    //     int customerId {get; set;}

    //     decimal price {get; set;}

    //     decimal cost {get; set;}

    //     decimal profit {get;set;}
}