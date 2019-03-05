using EcommerceWebAPI.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Maps
{
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.HasKey(x => x.CategoryId);
            this.Property(x => x.CategoryName).HasMaxLength(200).IsRequired();
            this.Property(x => x.Description).HasMaxLength(300).IsRequired();
            this.Property(x => x.Picture);
            this.Property(x => x.Active);
        }
    }
}