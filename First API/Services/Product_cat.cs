using First_API.Data;
using First_API.Interface;
using First_API.Models;

namespace First_API.Services
{
    public class Product_cat : IProduct_cat
    {
        private readonly StoreDB _dbContext;
        public Product_cat(StoreDB dbContext)
        {
            _dbContext = dbContext;
        }
        product_store IProduct_cat.Add(product_store data)
        {

            _dbContext.product_store.Add(data);
          
            _dbContext.SaveChanges();
            return data;


        }

        List<product_store> IProduct_cat.Get()
        {
            return _dbContext.product_store.ToList();
        }
    }
}
