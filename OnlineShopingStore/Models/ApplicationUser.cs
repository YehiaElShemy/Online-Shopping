using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public string FristName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}
