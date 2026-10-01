using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace PackingInventoryChallenge
{
    internal class Pack
    {
        public Pack(int maxItemCount,int maxWeight, int maxVolume)
        {
            MaxItems = new InventoryItem[maxItemCount];
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            Weight = 0;
            Volume = 0;

        }
        public InventoryItem[] MaxItems { get; init; }
        public int MaxWeight { get; init; }
        public int MaxVolume { get; init; }
        public float Weight { get; private set; }
        public float Volume { get; private set; }
        public int itemCount { get; private set; }
        public PackResult Result { get; private set; }


        public bool AddItem(InventoryItem item)
        {
            if (itemCount >= MaxItems.Length )
            {
                Result = PackResult.TooManyItems;
                return false;
            }
            if (item.Weight + Weight > MaxWeight)
            {
                Result = PackResult.TooHeavy;
                return false;
            }
            if (item.Volume + Volume > MaxVolume)
            {
                Result = PackResult.NotEnoughSpace;
                return false;
            }

            Result = PackResult.Success;
            itemCount++;
            Weight += item.Weight;
            Volume += item.Volume;
            MaxItems[itemCount - 1] = item;

            return true;
        }

    }
    enum PackResult
    {
        Success,
        NotEnoughSpace,
        TooHeavy,
        TooManyItems
    }
}
