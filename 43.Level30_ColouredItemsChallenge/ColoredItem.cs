using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace _43.Level30_ColouredItemsChallenge
{
    internal class ColoredItem<T>
    {
        private T GenericItem { get; }
        public ConsoleColor Color { get; set; }

        public ColoredItem(T item)
        {
            GenericItem = item;
        }


        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.Write($"a {Color.ToString()} ");
            Console.WriteLine($"{GenericItem.GetType().Name}");
            Console.ResetColor();
        }
    }
}