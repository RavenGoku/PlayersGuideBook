using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventoryChallenge
{
    public class Arrow : InventoryItem
    {
        // Constructor to initialize the weight and volume of the arrow
        public Arrow() : base(0.1m, 0.05m)
        {
           
        }
        
        public float Damage { get; }
    }
}
