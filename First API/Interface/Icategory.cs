using First_API.Models;

namespace First_API.Interface
{
    public interface Icategory
    {
        category Add(category data);
        List<category> Get();
    }
}
