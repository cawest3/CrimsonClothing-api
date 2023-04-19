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

            string stm = @"INSERT INTO customers(custusername, custPassword, storeCredit) VALUES(@custusername, @custPassword, @storeCredit)";
            using var cmd = new MySqlCommand(stm, con);

            // cmd.Parameters.AddWithValue("@customerId", newCustomer.customerId);
            cmd.Parameters.AddWithValue("@custusername", newCustomer.custusername);
            cmd.Parameters.AddWithValue("@custPassword", newCustomer.custPassword);
            cmd.Parameters.AddWithValue("@storeCredit", newCustomer.storeCredit);
            // cmd.Parameters.AddWithValue("@cart", newCustomer.cart);

            cmd.ExecuteNonQuery();
        }
    }
}