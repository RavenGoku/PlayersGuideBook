using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventoryChallenge
{
    public class FoodRations : InventoryItem
    {
        // Based on the requirements, the weight of food rations is 1 and the volume is 0.5
        public FoodRations() : base(1, 0.5m)
        {
        }
    }
}
