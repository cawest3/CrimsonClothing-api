namespace CrimsonClothing_api.Models
{
    public class Item
    {
        int itemId {get; set;}
        int itemImageSrc{get;set;}
        int price {get; set;}
        string size {get; set;}
        bool stock {get; set;}
        decimal value {get; set;}
        decimal profit {get; set;}
    }
}