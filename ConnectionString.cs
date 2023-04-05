namespace CrimsonClothing_api
{
    public class ConnectionString
    {
        public string cs {get;set;}
        public ConnectionString(){
            string server = "dt3bgg3gu6nqye5f.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "pwkzqi716f3wnnhk";
            string port = "3306";
            string username = "j6zys6h2gzwqy36t";
            string password = "lncxsjdfjfa3z03l";

            cs = $@"server = {server};user={username};database={database};port={port};password={password};";
        }
    }
}