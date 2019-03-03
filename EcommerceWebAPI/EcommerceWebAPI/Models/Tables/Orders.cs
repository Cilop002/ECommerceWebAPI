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

    }
}