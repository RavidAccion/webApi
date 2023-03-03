using First_API.Data;
using First_API.Interface;
using First_API.Models;

namespace First_API.Services
{
    public class catStore : IcatStore
    {
        private readonly StoreDB _dbContext;
        public catStore(StoreDB dbContext)
        {
            _dbContext = dbContext;
        }
        cat_store IcatStore.Add(cat_store data)
        {

            _dbContext.cat_store.Add(data);
            /*   try
               {
                   _dbContext.SaveChanges();
                   return data;
               }
               catch (Microsoft.EntityFrameworkCore.DbUpdateException )
               {
                   var err = "Exception caught: udate error";
                   return err;
                  Console.WriteLine("Exception caught: udate error" );
               }*/
            _dbContext.SaveChanges();
            return data;


        }

        List<cat_store> IcatStore.Get()
        {
            return _dbContext.cat_store.ToList();
        }
    }
}
