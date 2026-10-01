using System;
using System.Collections.Generic;
using System.Text;

namespace PackingInventoryChallenge
{
    public class Sword : InventoryItem
    {
        // Constructor to initialize the weight and volume of the sword
        public Sword() : base(5, 3)
        {
        }
    }
}
