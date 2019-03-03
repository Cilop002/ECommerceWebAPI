using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Tables
{
    public class Suppliers
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFName { get; set; }
        public string CompanyLName { get; set; }
        public string ContactTitle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int PostalCode { get; set; }
        public int Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public int PaymentMethod { get; set; }
        public int DiscountType { get; set; }
        public string Notes { get; set; }
        public bool DiscountAvailable { get; set; }
        public int CurrentOrder { get; set; }
        public string Logo { get; set; }
        public int CustomerId { get; set; }
    }
}