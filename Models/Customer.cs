using CrimsonClothing_api;

namespace CrimsonClothing_api.Models
{
    public class Customer
    {
        public int customerId {get; set;}
        public string username {get; set;}
        public string password {get; set;}
        public decimal storeCredit {get; set;}
        public string cart{get; set;}
    }
}