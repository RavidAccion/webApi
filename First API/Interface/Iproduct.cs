using First_API.Models;
using System.Threading.Tasks;

namespace First_API.Interface
{
    public interface Iproduct
    {
        product Add(product data);
        List<product> Get();
        void Delete(product data);
        product EditProduct(product data);
        product GetProduct(int prodId);
    }
}
