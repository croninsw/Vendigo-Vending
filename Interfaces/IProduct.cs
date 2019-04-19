using System;
using System.Collections.Generic;

namespace Vendigo
{
    public interface IProduct<T>
    {
        string Name { get; set; }

        double Price { get; set; }

    }
}