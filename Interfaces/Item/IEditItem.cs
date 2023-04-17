using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IEditItem
    {
        void EditItem(Item editItem, int Id);
    }
}