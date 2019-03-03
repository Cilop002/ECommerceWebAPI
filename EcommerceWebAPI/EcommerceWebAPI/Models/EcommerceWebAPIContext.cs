using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models
{
    public class EcommerceWebAPIContext: DbContext
    {
        public EcommerceWebAPIContext() : base("name=EcommerceWebAPI")
        {

        }

    }
}