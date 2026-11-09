namespace _43.Level30_ColouredItemsChallenge
{
    /* -------------------- COLORED ITEMS --------------------
                                Level 30 - Generics
                                     100 XP

               You have three items: a Sword, a Bow, and an Axe.

               You want to associate a color with each item without
               creating a separate colored class for every item type.

               Generics allow you to create a reusable ColoredItem
               class that works with different types of items.

               OBJECTIVES:

               1. Create a new project containing these classes:
                  Sword, Bow, and Axe.

               2. Create a generic ColoredItem class containing:
                  - A property for the item (generic type).
                  - A ConsoleColor property for its color.

               3. Add a void Display() method that:
                  - Changes the console foreground color.
                  - Displays the item in its assigned color.
                  - Can use ToString() for the item's text.

               4. In Main(), create:
                  - A blue Sword.
                  - A red Bow.
                  - A green Axe.

               5. Display all three items in their respective colors.

               -------------------------------------------------------
            */
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new();
            ColoredItem<Sword> RedSword = new(sword);
            RedSword.Color = ConsoleColor.Red;

            Bow bow = new();
            ColoredItem<Bow> BlueBow = new(bow);
            BlueBow.Color = ConsoleColor.Blue;

            Axe axe = new();
            ColoredItem<Axe> GreenAxe = new(axe);
            GreenAxe.Color = ConsoleColor.Green;

            RedSword.Display();
            BlueBow.Display();
            GreenAxe.Display();
        }
    }
}