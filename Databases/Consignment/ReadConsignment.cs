using CrimsonClothing_api.Interfaces;
using CrimsonClothing_api.Models;
using MySql.Data.MySqlClient;


namespace CrimsonClothing_api.Databases.Consignment
{
    public class ReadConsignment : IReadConsignment //this error is confusing, sometimes I implement, sometimes I don't
    {
        public List<Consignment> GetConsignments(){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM onsignments"; //help
            using var cmd = new MySqlCommand(stm, con);

            List<Consignments> onsignments = new List<Consignments>();

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read()){
                Consignment consignment = new Consignment()
                {
                    consignmentId = read.GetInt32(0),
                    customerId = read.GetInt32(1),
                    price = read.GetString(2)
                };
                admins.Add(song);
            }

            return admins; 
        
        }

        public Admin GetAdmin(int Id){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM songs WHERE adminId=@Id";
            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@Id", Id); //should Id be songId in first parm
            cmd.Prepare();
            MySqlDataReader read = cmd.ExecuteReader();

            read.Read();

            Admin myAdmin = new Admin(){
                adminId = read.GetInt32(0),
                adminUsername = read.GetString(1),
                adminPassword = read.GetString(2)
            };

            return myAdmin;
        }
    }
}