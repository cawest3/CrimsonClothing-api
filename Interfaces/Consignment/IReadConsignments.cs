using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IReadConsignments
    {
        public interface IReadConsignments{
            public List<Consignment> GetConsignments();

            public Consignment GetConsignment(int Id);
    
        }
    }
}