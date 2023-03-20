using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        [Required( ErrorMessage ="The Product Type Is Required")]
        [Display(Name ="Product Type")]
        public string Producttype { get; set; }

    }
}
