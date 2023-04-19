using CrimsonClothing_api.Models;

namespace CrimsonClothing_api
{
    public interface IReadItem
    {
        public interface IReadItem{
            public List<Item> GetItems();

            public Admin GetItem(int Id);
    
        }
    }
}