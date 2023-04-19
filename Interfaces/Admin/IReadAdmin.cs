using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IReadAdmin
    {
        public interface IReadData{
            public List<Admin> GetAdmins();

            public Admin GetAdmin(int Id);
    
        }
    }
}