
using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api;
public class SaveAdmin : ISaveAdmin
    {
        public void AddAdmin(Admin newAdmin)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO ADMIN(adminId, username, password) VALUES(@adminId, @username, @password)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@songId", newAdmin.adminId);
            cmd.Parameters.AddWithValue("@title", newAdmin.username);
            cmd.Parameters.AddWithValue("@artist", newAdmin.password);

            cmd.ExecuteNonQuery();
        }
    }


        // int adminId {get; set;}
        // string username {get; set;}
        // string password {get; set;}