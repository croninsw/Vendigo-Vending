using System;

namespace Vendigo
{
    public class PreparedFood : IProduct<PreparedFood>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}