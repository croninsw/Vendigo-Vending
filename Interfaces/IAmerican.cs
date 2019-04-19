using System;
using System.Collections.Generic;

namespace Vendigo
{
    public interface IAmerican<T>
    {
        string Ingredients { get; set; }

        bool Recyclable { get; set; }

    }
}