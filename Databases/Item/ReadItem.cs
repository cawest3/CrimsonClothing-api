using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public class ReadItem : IReadItem
    {
        //     public List<Song> GetSongs(){

    //         ConnectionString myConnection = new ConnectionString();
    //         string cs = myConnection.cs;
    //         using var con = new MySqlConnection(cs);
    //         con.Open();

    //         string stm = @"SELECT * FROM songs"; //help
    //         using var cmd = new MySqlCommand(stm, con);

    //         List<Song> songs = new List<Song>();

    //         MySqlDataReader read = cmd.ExecuteReader();

    //         while(read.Read()){
    //             Song song = new Song()
    //             {
    //                 songId = read.GetInt32(0),
    //                 title = read.GetString(1),
    //                 artist = read.GetString(2),
    //                 createDate = read.GetDateTime(3),
    //                 favorite = read.GetBoolean(4),
    //                 deleteStatus = read.GetBoolean(5)
    //             };
    //             songs.Add(song);
    //         }

    //         return songs; 
        
    //     }
    }
}