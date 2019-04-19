using System;

namespace Vendigo
{
    public class Sundry : IProduct<Sundry>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}