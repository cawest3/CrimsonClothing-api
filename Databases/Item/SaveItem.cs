using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class SaveItem : ISaveItem
    {
        public void AddItem(Item newItem)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO Items(itemId, itemImageSrc, price, size, stock, value, profit) VALUES(@itemId, @itemImageSrc, @price, @size, @stock, @value, @profit)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@itemId", newItem.itemId);
            cmd.Parameters.AddWithValue("@itemImageSrc", newItem.itemImageSrc);
            cmd.Parameters.AddWithValue("@price", newItem.price);
            cmd.Parameters.AddWithValue("@size", newItem.size);
            cmd.Parameters.AddWithValue("@stock", newItem.stock);
            cmd.Parameters.AddWithValue("@value", newItem.value);
            cmd.Parameters.AddWithValue("@profit", newItem.profit);

            cmd.ExecuteNonQuery();
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