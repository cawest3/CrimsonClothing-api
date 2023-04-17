using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class EditConsignment : IEditConsignment
    {
        void IEditConsignment.EditConsignment(Consignment editConsignment, int Id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE CONSIGNMENTS SET consignmentId=@consignmentId, customerId=@customerId, price=@price, cost=@cost, profit=@profit, consignmentImageSrc=@consignmentImageSrc WHERE consignmentId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@consignmentId", editConsignment.consignmentId);
            cmd.Parameters.AddWithValue("@customerId", editConsignment.customerId);
            cmd.Parameters.AddWithValue("@price", editConsignment.price);
            cmd.Parameters.AddWithValue("@cost", editConsignment.cost);
            cmd.Parameters.AddWithValue("@profit", editConsignment.profit);
            cmd.Parameters.AddWithValue("@consignmentImageSrc", editConsignment.consignmentImageSrc);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }
    }


    //     int consignmentId {get; set;}

    //     int customerId {get; set;}

    //     decimal price {get; set;}

    //     decimal cost {get; set;}

    //     decimal profit {get;set;}
}