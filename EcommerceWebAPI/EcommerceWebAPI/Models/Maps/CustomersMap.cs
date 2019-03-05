using EcommerceWebAPI.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Maps
{
    public class CustomersMap: EntityTypeConfiguration<Customers>
    {
        public CustomersMap()
        {
            this.HasKey(x => x.CustomerId);
            this.Property(x => x.FirstName).HasMaxLength(200).IsRequired();
            this.Property(x => x.LastName).HasMaxLength(300).IsRequired();
            this.Property(x => x.Class);
            this.Property(x => x.Room);
        }
    }
}