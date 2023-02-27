using First_API.Models;
using System;
using System.Collections.Generic;


namespace First_API.Interface
{
    public interface Istores
    {
        stores Add(stores data);
      
        List<stores>Get();
    }

    
}
