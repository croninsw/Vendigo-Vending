using System;
using System.Collections.Generic;

namespace Vendigo
{
    public interface IVendingMachine<T>
    {
        List<T> products { get; set; }

        void AddProduct (T product);

        void SellProduct (T product);
    }
}