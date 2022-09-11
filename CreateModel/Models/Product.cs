using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateModel.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; } // İlişki kurmadığımız için categoryıd ve name i burada tekrar tanımladık!
        public string CategoryName { get; set; }
        public bool ProductStatus { get; set; }
        
    }
}