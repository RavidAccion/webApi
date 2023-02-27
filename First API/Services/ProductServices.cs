using First_API.Data;
using First_API.Interface;
using First_API.Models;

namespace First_API.Services
{
    public class ProductServices : Iproduct
    {
        private readonly StoreDB _dbContext;
        public ProductServices(StoreDB dbContext)
        {
            _dbContext = dbContext;
        }
        product Iproduct.Add(product data)
        {

            _dbContext.product.Add(data);
            _dbContext.SaveChanges();
            return data;
        }

        List<product> Iproduct.Get()
        {
            return _dbContext.product.ToList();
        }
    }  
}
