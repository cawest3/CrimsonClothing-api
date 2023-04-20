using CrimsonClothing_api.Models;
using MySql.Data.MySqlClient;

namespace CrimsonClothing_api
{
    public class ReadAdmin : IReadAdmin
    {
         public List<Admin> GetAdmins(){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM admins"; //help
            using var cmd = new MySqlCommand(stm, con);

            List<Admin> Admins = new List<Admin>();

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read()){
                Admin thisAdmin = new Admin()
                {
                    adminId = read.GetInt32(0),
                    adminUsername = read.GetString(1),
                    adminPassword = read.GetString(2),
                };
                Admins.Add(thisAdmin);
            }

            return Admins; 
        
        }

            public Admin GetAdmin(int Id){

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM songs WHERE songId=@Id";
            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@Id", Id); //should Id be songId in first parm
            cmd.Prepare();
            MySqlDataReader read = cmd.ExecuteReader();

            read.Read();

            Admin myAdmin = new Admin(){
                adminId = read.GetInt32(0),
                adminUsername = read.GetString(1),
                adminPassword = read.GetString(2),
            };

            return myAdmin;
        }
    }
}
