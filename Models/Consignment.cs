namespace CrimsonClothing_api.Models
{
    public class Consignment
    {
        int consignmentId {get; set;}

        int customerId {get; set;}

        decimal price {get; set;}

        decimal cost {get; set;}
        
        decimal profit {get;set;}
    }
}