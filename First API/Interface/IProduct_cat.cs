using First_API.Models;

namespace First_API.Interface
{
    public interface IProduct_cat
    {
        product_store Add(product_store data);

        List<product_store> Get();
    }
}
