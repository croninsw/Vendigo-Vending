using System;

namespace Vendigo
{
    public class PreparedFood : IPreparedFood
    {
        public string PreparedFoodName { get; set; }
        public double PreparedFoodPrice { get; set; }
    }
}