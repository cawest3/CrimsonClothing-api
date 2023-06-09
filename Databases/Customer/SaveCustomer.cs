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

            string stm = @"INSERT INTO customers(custusername, custPassword, storeCredit, cart, custFName, custLname) VALUES(@custusername, @custPassword, @storeCredit, @cart, @custFName, @custLName)";
            using var cmd = new MySqlCommand(stm, con);

            // cmd.Parameters.AddWithValue("@customerId", newCustomer.customerId);
            cmd.Parameters.AddWithValue("@custusername", newCustomer.custusername);
            cmd.Parameters.AddWithValue("@custPassword", newCustomer.custPassword);
            cmd.Parameters.AddWithValue("@storeCredit", newCustomer.storeCredit);
            cmd.Parameters.AddWithValue("@cart", newCustomer.cart);
            cmd.Parameters.AddWithValue("@custFName", newCustomer.custFName);
            cmd.Parameters.AddWithValue("@custLName", newCustomer.custLName);

            cmd.ExecuteNonQuery();
        }
    }
}