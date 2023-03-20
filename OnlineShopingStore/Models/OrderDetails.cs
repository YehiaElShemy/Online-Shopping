﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        [Display(Name ="Order")]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Products product { get; set; }
      
    }
}
