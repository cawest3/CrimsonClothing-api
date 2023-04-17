
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

            string stm = @"UPDATE songs SET adminId=@adminId, username=@username, password=@password WHERE adminId=@Id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@adminId", editAdmin.adminId);
            cmd.Parameters.AddWithValue("@username", editAdmin.username);
            cmd.Parameters.AddWithValue("@password", editAdmin.password);
            cmd.Parameters.AddWithValue("@Id", Id);

            cmd.ExecuteNonQuery();
        }
    }
}