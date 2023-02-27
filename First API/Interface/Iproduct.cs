using First_API.Models;

namespace First_API.Interface
{
    public interface Iproduct
    {
        product Add(product data);
        List<product> Get();
    }
}
