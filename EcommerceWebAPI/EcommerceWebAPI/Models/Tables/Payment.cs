using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Tables
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
        public virtual Orders Orders { get; set; }
    }
}