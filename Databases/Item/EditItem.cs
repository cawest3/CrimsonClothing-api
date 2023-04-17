using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class EditItem : IEditItem
    {
        void IEditItem.EditItem(Item editItem, int Id)
        {
        //     ConnectionString myConnection = new ConnectionString();
        //     string cs = myConnection.cs;
        //     using var con = new MySqlConnection(cs);
        //     con.Open();

        //     string stm = @"UPDATE ITEMS SET consignmentId=@consignmentId, customerId=@customerId, price=@price, cost=@cost, profit=@profit WHERE consignmentId=@Id";

        //     using var cmd = new MySqlCommand(stm, con);

        //     // cmd.Parameters.AddWithValue("@", editConsignment.consignmentId);
        //     // cmd.Parameters.AddWithValue("@customerId", editConsignment.customerId);
        //     // cmd.Parameters.AddWithValue("@price", editConsignment.price);
        //     // cmd.Parameters.AddWithValue("@cost", editConsignment.cost);
        //     // cmd.Parameters.AddWithValue("@profit", editConsignment.profit);
        //     // cmd.Parameters.AddWithValue("@Id", Id);

        //     cmd.ExecuteNonQuery();
        }
    }
}

        // public int itemId {get; set;}
        // public int itemImageSrc{get;set;}
        // public int price {get; set;}
        // public string size {get; set;}
        // public bool stock {get; set;}
        // public decimal value {get; set;}
        // public decimal profit {get; set;}
        // public bool inCart {get; set;}