using First_API.Data;
using First_API.Interface;
using First_API.Models;
using System.Threading.Tasks;

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

        product Iproduct.GetProduct(int prodId)
        {
            var task = _dbContext.product.Find(prodId);

            return task;

        }
        void Iproduct.Delete(product data)
        {
            if (data != null)
            {
                _dbContext.Remove(data);
                _dbContext.SaveChanges();
            }
        }
        List<product> Iproduct.Get()
        {
            return _dbContext.product.ToList();
        }

        product Iproduct.EditProduct(product data)
        {
            var existingdata = _dbContext.product.Find(data.Id);
            if (existingdata != null)
            {

                existingdata.added_on= DateTime.Now;
                existingdata.product_Name = data.product_Name;
                existingdata.price = data.price;
                existingdata.quantity = data.quantity;
                existingdata.product_description = data.product_description;

            }
            _dbContext.product.Update(existingdata);
            _dbContext.Entry(existingdata)
                .Property(x => x.Id).IsModified = false; // To Prevent Idenity column update issue
            _dbContext.SaveChanges();
            return data;

        }
    }  
}
