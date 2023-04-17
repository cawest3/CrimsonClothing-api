
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

            string stm = @"INSERT INTO ADMIN(adminId, username, adminPassword) VALUES(@adminId, @username, @adminPassword)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@adminId", newAdmin.adminId);
            cmd.Parameters.AddWithValue("@username", newAdmin.username);
            cmd.Parameters.AddWithValue("@adminPassword", newAdmin.adminPassword);

            cmd.ExecuteNonQuery();
        }
    }


        // int adminId {get; set;}
        // string username {get; set;}
        // string password {get; set;}