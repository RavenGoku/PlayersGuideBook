using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
        private InventoryItem[] MaxItems { get; }
        public int MaxItemCount => MaxItems.Length;
        public int MaxWeight { get; }
        public int MaxVolume { get; }
        public float Weight { get; private set; } 
        public float Volume { get; private set; } 
        public int ItemCount { get; private set; }
        public PackResult Result { get; private set; }

        public bool Add(InventoryItem item)
        {
            if (ItemCount >= MaxItems.Length )
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
            ItemCount++;
            Weight += item.Weight;
            Volume += item.Volume;
            MaxItems[ItemCount - 1] = item;

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
