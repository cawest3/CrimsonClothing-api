using CrimsonClothing_api.Models;
using MySql.Data.MySqlClient;

namespace CrimsonClothing_api
{
    public class ReadCustomer : IReadCustomer
    {
         public List<Customer> GetCustomers(){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM customers"; //help
            using var cmd = new MySqlCommand(stm, con);

            List<Customer> Customers = new List<Customer>();

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read()){
                Customer thisCustomer = new Customer()
                {
                    customerId = read.GetInt32(0),
                    custusername = read.GetString(1),
                    custPassword = read.GetString(2),
                    storeCredit = read.GetDecimal(3),
                    cart = read.GetString(4),
                    custFName = read.GetString(5),
                    custLName = read.GetString(6)
                };
                Customers.Add(thisCustomer);
            }

            return Customers;
        
        }
    }
}