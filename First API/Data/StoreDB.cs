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
        public DbSet<Electronics> electronics { get; set; }
        public DbSet<Fashions> fashions { get; set; }
        public DbSet<Groceries> groceries { get; set; }
    }
}
