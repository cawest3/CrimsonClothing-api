namespace CrimsonClothing_api.Models
{
    public class Customer
    {
        public int customerId {get; set;}
        public string custusername {get; set;} //this is email
        public string custPassword {get; set;}
        public decimal storeCredit {get; set;}
        public string cart{get; set;}
        public string custFName {get; set;}
        public string custLName {get; set;}
    }
}