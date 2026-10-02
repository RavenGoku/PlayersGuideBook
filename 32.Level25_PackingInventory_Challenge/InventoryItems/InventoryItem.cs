using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventoryChallenge
{
    public class InventoryItem
    {
        // Constructor to initialize the weight and volume of the inventory item
        public InventoryItem(decimal weight,decimal volume)
        {
            Weight = weight;
            Volume = volume;
        }
        // Properties to get the weight and volume of the inventory item
        public decimal Weight { get;}
        public decimal Volume { get; }
    }
}
