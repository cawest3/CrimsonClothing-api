using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface ISaveConsignment
    {
        void AddConsignment(Consignment newConsignment);
    }
}