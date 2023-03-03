using First_API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace First_API.Interface
{
    public interface Istores
    {
        stores Add(stores data);

        /*  stores GetStorebyID(Guid store_id);*/
        /*  void DeleteStore(stores store_id);*/
        List<stores>Get();
    }

    
}
