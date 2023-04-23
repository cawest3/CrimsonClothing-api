using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class EditCustomer : IEditCustomer
    {
        void IEditCustomer.EditCustomer(Customer editCustomer, int Id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE customers SET customerId=@customerId, custusername=@custusername, custPassword=@custPassword, storeCredit=@storeCredit, cart=@cart, custFName=@custFName, custLName=@custLName WHERE customerId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@customerId", editCustomer.customerId);
            cmd.Parameters.AddWithValue("@custusername", editCustomer.custusername);
            cmd.Parameters.AddWithValue("@custPassword", editCustomer.custPassword);
            cmd.Parameters.AddWithValue("@storeCredit", editCustomer.storeCredit);
            cmd.Parameters.AddWithValue("@cart", editCustomer.cart);
            cmd.Parameters.AddWithValue("@custFName", editCustomer.custFName);
            cmd.Parameters.AddWithValue("@custLName", editCustomer.custLName);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }

        // int customerId {get; set;}
        // string username {get; set;}
        // string password {get; set;}
        // decimal storeCredit {get; set;}
        // public int[] cart{get; set;} //itemids
    }
}