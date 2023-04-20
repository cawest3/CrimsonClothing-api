using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IReadAdmin
    {
        List<Admin> GetAdmins();

        public interface IReadData{
            public List<Admin> GetAdmins();
    
        }
    }
}