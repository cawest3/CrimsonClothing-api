using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class EditItem : IEditItem
    {
        void IEditItem.EditItem(Item editItem, int Id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE ITEMS SET itemId=@itemId, itemImageSrc=@itemImageSrc, price=@price, stock=@stock, value=@value WHERE itemId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@itemId", editItem.itemId);
            cmd.Parameters.AddWithValue("@itemImageSrc", editItem.itemImageSrc);
            cmd.Parameters.AddWithValue("@price", editItem.price);
            cmd.Parameters.AddWithValue("@size", editItem.size);
            cmd.Parameters.AddWithValue("@stock", editItem.stock);
            cmd.Parameters.AddWithValue("@value", editItem.value);
            cmd.Parameters.AddWithValue("@profit", editItem.profit);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }
    }
}

        // public int itemId {get; set;}
        // public string itemImageSrc{get;set;}
        // public int price {get; set;}
        // public string size {get; set;}
        // public bool stock {get; set;}
        // public decimal value {get; set;}
        // public decimal profit {get; set;}
        // public bool inCart {get; set;}