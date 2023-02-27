using First_API.Data;
using First_API.Interface;
using First_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace First_API.Services
{
    public class storesService : Istores, Icatstore
    {
        private readonly StoreDB _dbContext;
        public storesService(StoreDB dbContext)
        {
            _dbContext = dbContext;
        }
   
        stores Istores.Add(stores data)
        {

            _dbContext.stores.Add(data);
            _dbContext.SaveChanges();

            var _id = data.store_id;

            return data;
      
            
        

        }


   

        List<stores> Istores.Get()
        {
            return _dbContext.stores.ToList();
        }
    }
}
