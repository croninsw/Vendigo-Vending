using System;

namespace Vendigo
{
    public class Clothing : IProduct<Clothing>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}