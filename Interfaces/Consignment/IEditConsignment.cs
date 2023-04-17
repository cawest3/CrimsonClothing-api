using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IEditConsignment
    {
        public void EditConsignment(Consignment editConsignment, int Id);
    }
}