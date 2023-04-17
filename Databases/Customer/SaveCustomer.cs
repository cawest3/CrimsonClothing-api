using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class SaveCustomer : ISaveCustomer
    {
        public void AddCustomer(Customer newCustomer)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO CUSTOMERS(customerId, username, password, storeCredit, cart) VALUES(@customerId, @username, @password, @storeCredit, @cart)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@customerId", newCustomer.customerId);
            cmd.Parameters.AddWithValue("@username", newCustomer.username);
            cmd.Parameters.AddWithValue("@password", newCustomer.password);
            cmd.Parameters.AddWithValue("@storeCredit", newCustomer.storeCredit);
            cmd.Parameters.AddWithValue("@cart", newCustomer.cart);

            cmd.ExecuteNonQuery();
        }
    }
}