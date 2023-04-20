using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;


namespace CrimsonClothing_api
{
    public class ReadItem : IReadItem
    {
            public List<Item> GetItems(){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM items"; //help
            using var cmd = new MySqlCommand(stm, con);

            List<Item> Items = new List<Item>();

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read()){
                Item thisItem = new Item()
                {
                    itemId = read.GetInt32(0),
                    itemImageSrc = read.GetString(1),
                    price = read.GetDecimal(2),
                    size = read.GetString(3),
                    stock = read.GetBoolean(4),
                    cost = read.GetDecimal(5),
                    profit = read.GetDecimal(6),
                    inCart = read.GetBoolean(7),
                    consignmentId = read.GetInt32(8)
                };
                Items.Add(thisItem);
            }

            return Items; 
        
        }
    }
}