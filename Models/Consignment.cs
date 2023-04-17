namespace CrimsonClothing_api.Models
{
    public class Consignment
    {
        public int consignmentId {get; set;}

        public int customerId {get; set;}

        public decimal price {get; set;}

        public decimal cost {get; set;}
        
        public decimal profit {get;set;}
        public string consignmentImageSrc {get; set;}
    }
}