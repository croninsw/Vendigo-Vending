using System;

namespace Vendigo
{
    public interface IPreparedFood
    {
        string PreparedFoodName { get; set; }
        double PreparedFoodPrice { get; set; }
    }
}