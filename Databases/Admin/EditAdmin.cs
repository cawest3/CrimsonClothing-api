
using MySql.Data.MySqlClient;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api.Databases.Admin
{
    public class EditAdmin : IEditAdmin
    {
        void IEditAdmin.EditAdmin(Models.Admin editAdmin, int Id){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE admins SET adminId=@adminId, adminUsername=@adminUsername, adminPassword=@adminPassword WHERE adminId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@adminId", editAdmin.adminId);
            cmd.Parameters.AddWithValue("@adminUsername", editAdmin.adminUsername);
            cmd.Parameters.AddWithValue("@adminPassword", editAdmin.adminPassword);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }
    }
}