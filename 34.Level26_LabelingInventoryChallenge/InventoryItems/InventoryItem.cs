using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace PackingInventoryChallenge
{
    // Base class for inventory items with weight and volume properties
    public class InventoryItem
    {
        // Constructor to initialize the weight and volume of the inventory item
        public InventoryItem(decimal weight, decimal volume)
        {
            Weight = weight;
            Volume = volume;
        }

        

        // Properties to get the weight and volume of the inventory item
        public decimal Weight { get; }
        public decimal Volume { get; }
    }
}