using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShopingStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopingStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductType>ProductTypes { get; set; }
        public DbSet<SpecialTag> specialTags { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<ApplicationUser> ApllicationUsers { get; set; }
        
    }
}
