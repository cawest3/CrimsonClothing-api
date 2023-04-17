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

            string stm = @"UPDATE CUSTOMERS SET customerId=@customertId, usernameId=@username, custPassword=@custPassword, storeCredit=@storeCredit, cart=@cart WHERE customerId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@customerId", editCustomer.customerId);
            cmd.Parameters.AddWithValue("@username", editCustomer.username);
            cmd.Parameters.AddWithValue("@custPassword", editCustomer.custPassword);
            cmd.Parameters.AddWithValue("@storeCredit", editCustomer.storeCredit);
            cmd.Parameters.AddWithValue("@cart", editCustomer.cart);
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