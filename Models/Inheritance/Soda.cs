using System;

namespace Vendigo
{
    public class Soda : IProduct<Soda>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}