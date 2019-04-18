using System;

namespace Vendigo
{
    public interface IClothingItem
    {
        string ClothingItemName { get; set; }
        double ClothingItemPrice { get; set; }
    }
}