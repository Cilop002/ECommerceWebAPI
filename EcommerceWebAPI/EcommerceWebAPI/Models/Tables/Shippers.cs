﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebAPI.Models.Tables
{
    public class Shippers
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}