﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{
    public class Product
    {
        public string Title { get; set; }
        public int PId { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl
        {
            get; set;
        }
    }
}
