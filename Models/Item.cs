using CrimsonClothing_api;

namespace CrimsonClothing_api.Models
{
    public class Item
    {
        public int itemId {get; set;}
        public string itemImageSrc{get;set;}
        public decimal price {get; set;}
        public string size {get; set;}
        public bool stock {get; set;}
        public decimal cost {get; set;}
        public decimal profit {get; set;}
        public bool inCart {get; set;}
        public int consignmentId{get; set;}
        public string itemName {get; set;}
    }
}