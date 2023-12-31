﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int ProductCode { get; set; }
        public string  ProductContent { get; set; }
        public string  ProductPicture { get; set; }
        public int ProductPrice { get; set; }
        public bool ProductStatus { get; set; }
        public int? CategoryId { get; set; }
        public  virtual Category Category { get; set; }
    }
}
