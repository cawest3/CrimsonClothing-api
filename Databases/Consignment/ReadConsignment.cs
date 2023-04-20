using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class ReadConsignment : IReadConsignment
    {
        public List<Consignment> GetConsignments(){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM consignments"; //help
            using var cmd = new MySqlCommand(stm, con);

            List<Consignment> Consignments = new List<Consignment>();

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read()){
                Consignment thisConsignment = new Consignment()
                {
                    consignmentId = read.GetInt32(0),
                    customerId = read.GetInt32(1),
                    price = read.GetDecimal(2),
                    cost = read.GetDecimal(3),
                    profit = read.GetDecimal(4),
                    consignmentImageSrc = read.GetString(5)
                };
                Consignments.Add(thisConsignment);
            }

            return Consignments;
        }
    }
}