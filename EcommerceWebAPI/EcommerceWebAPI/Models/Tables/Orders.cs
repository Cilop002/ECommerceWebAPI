using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Tables
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customers Customers { get; set; }
        public int OrderNumber { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}