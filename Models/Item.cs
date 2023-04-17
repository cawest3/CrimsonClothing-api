using CrimsonClothing_api;

namespace CrimsonClothing_api.Models
{
    public class Item
    {
        public int itemId {get; set;}
        public int itemImageSrc{get;set;}
        public int price {get; set;}
        public string size {get; set;}
        public bool stock {get; set;}
        public decimal value {get; set;}
        public decimal profit {get; set;}
        public bool inCart {get; set;}
    }
}