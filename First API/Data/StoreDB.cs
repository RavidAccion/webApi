using First_API.Interface;
using First_API.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace First_API.Data
{
    public class StoreDB : DbContext

    {
        public StoreDB(DbContextOptions<StoreDB> options) : base(options)
        {

        }
      
        public DbSet<stores> stores { get; set; }
        public DbSet<product> product { get; set; }
        public DbSet<cat_store> cat_store { get; set; }
        public DbSet<category> category { get; set; }
        public DbSet<product_store> product_store { get; set; }
    }
}
