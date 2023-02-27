using First_API.Models;
using Microsoft.EntityFrameworkCore;

namespace First_API.Interface
{
    public interface IDbContext
    {
    

  
        public DbSet<stores> stores { get; set; }
        public DbSet<product> product { get; set; }

        void SaveChanges();
    }
}
