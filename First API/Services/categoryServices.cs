using First_API.Data;
using First_API.Interface;
using First_API.Models;

namespace First_API.Services
{
    public class categoryServices : Icategory
    {
        private readonly StoreDB _dbContext;
        public categoryServices(StoreDB dbContext)
        {
            _dbContext = dbContext;
        }
        category Icategory.Add(category data)
        {

            _dbContext.category.Add(data);
            _dbContext.SaveChanges();
            return data;
        }

        List<category> Icategory.Get()
        {
            return _dbContext.category.ToList();
        }
    }
}
