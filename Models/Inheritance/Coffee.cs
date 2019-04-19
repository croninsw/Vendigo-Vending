using System;

namespace Vendigo
{
    public class Coffee : IProduct<Coffee>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}