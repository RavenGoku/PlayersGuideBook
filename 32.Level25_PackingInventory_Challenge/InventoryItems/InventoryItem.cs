using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventoryChallenge
{
    public class InventoryItem
    {
        // Constructor to initialize the weight and volume of the inventory item
        public InventoryItem(float weight,float volume)
        {
            Weight = weight;
            Volume = volume;
        }
        // Properties to get the weight and volume of the inventory item
        public float Weight { get; init; }
        public float Volume { get; init; }
    }
}
