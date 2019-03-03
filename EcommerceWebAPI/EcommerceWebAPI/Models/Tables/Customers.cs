using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Tables
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public string Room { get; set; }
        public string Building { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int PostalCode { get; set; }
        public int Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string VoiceMail { get; set; }
        public string Password { get; set; }
        public string CreditCard { get; set; }
        public int CreditCardTypeId { get; set; }
        public int CardExpMo { get; set; }
        public int CardExpYr { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public DateTime DateEntered { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}