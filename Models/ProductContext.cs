﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prjMDA.Models
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}