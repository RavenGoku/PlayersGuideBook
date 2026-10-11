using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace PackingInventoryChallenge
{
    internal class Pack
    {
        public Pack(int maxItemCount, int maxWeight, int maxVolume)
        {
            _items = new InventoryItem[maxItemCount];
            MaxItemCount = _items.Length;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            Weight = 0;
            Volume = 0;
        }

        private readonly InventoryItem[] _items;
        public int MaxItemCount { get; }
        public int MaxWeight { get; }
        public int MaxVolume { get; }
        public decimal Weight { get; private set; }
        public decimal Volume { get; private set; }
        public int ItemCount { get; private set; }

        public bool Add(InventoryItem item)
        {
            if (ItemCount >= _items.Length)
            {
                return false;
            }

            if (item.Weight + Weight > MaxWeight)
            {
                return false;
            }

            if (item.Volume + Volume > MaxVolume)
            {
                return false;
            }

            ItemCount++;
            Weight += item.Weight;
            Volume += item.Volume;
            _items[ItemCount - 1] = item;

            return true;
        }

        public override string ToString()
        {
            string itemName = "Pack Containing: ";

            //GetItem is a local function that returns the string representation of an InventoryItem
            string GetItem(InventoryItem item) => item.ToString();

            //Use of GetItem local function to sort the items in the pack by their string representation
            InventoryItem[] _sortedItems = _items.Take(ItemCount).OrderBy(GetItem).ToArray();

            for (int i = 0; i < ItemCount; i++)
            {
                itemName += _sortedItems[i] + " ";
            }

            return itemName.TrimEnd();
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