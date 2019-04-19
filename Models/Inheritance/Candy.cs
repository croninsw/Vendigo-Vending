using System;

namespace Vendigo
{
    public class Candy : IProduct<Candy>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}