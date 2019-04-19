using System;
using System.Collections.Generic;

namespace Vendigo
{
    public interface IVendingMachine<T>
    {
        List<T> currentStock { get; set; }

        List<T> soldItems { get; set; }

        void AddProduct (T currentStock);

        void SellProduct (T currentStock);
    }
}