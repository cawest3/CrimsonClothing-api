using CrimsonClothing_api;

namespace CrimsonClothing_api.Models
{
    public class Customer
    {
        int customerId {get; set;}
        string username {get; set;}
        string password {get; set;}
        decimal storeCredit {get; set;}
        public int[] cart{get; set;} //itemids
    }
}