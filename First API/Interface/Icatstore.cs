using First_API.Models;

namespace First_API.Interface
{
    public interface IcatStore
    {
        cat_store Add(cat_store data);

        List<cat_store> Get();
    }
}
