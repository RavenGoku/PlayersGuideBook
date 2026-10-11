using PackingInventoryChallenge;
/*
                          Challenge   Labeling Inventory   50 XP
   You realize that your inventory items are not easy to sort through. If you could make it easy to label all
   of your inventory items, it would be easier to know what items you have in your pack.
   Modify your inventory program from the previous level as described below.

   Objectives:
   •   Override the existing ToString method (from the object base class) on all of your inventory item
   subclasses to give them a name. For example, new Rope().ToString() should return "Rope".

   •   Override ToString on the Pack class to display the contents of the pack. If a pack contains water,
   rope, and two arrows, then calling ToString on that Pack object could look like "Pack
   containing Water Rope Arrow Arrow".

   •   Before the user chooses the next item to add, display the pack’s current contents via its new
   ToString method. */
using PackingInventoryChallenge;
using System.Linq.Expressions;

Pack backpack = new Pack(10, 25, 15);

//
Console.WriteLine("=== PACKING INVENTORY ===\n\n");
Console.WriteLine("A long journey awaits. Pack your supplies wisely!\r\n" +
                  $"Your backpack has limits for:\n - Item count: {backpack.MaxItemCount}\n - Weight:{backpack.MaxWeight}\n - Volume:{backpack.MaxVolume}.\n\n");
Console.WriteLine("Choose an item to add:\n" +
                  "1. Arrow  \n" +
                  "2. Bow\n" +
                  "3. Rope\n" +
                  "4. Water\n" +
                  "5. Food Rations\n" +
                  "6. Sword\n" +
                  "0. Finish packing\n\n");

int choice;

while (true)
{
    Console.WriteLine(backpack.ToString());
    Console.WriteLine("Backpack Status:\n" +
                      $"- Items: {backpack.ItemCount}/{backpack.MaxItemCount}\n" +
                      $"- Weight: {backpack.Weight}/{backpack.MaxWeight}\n" +
                      $"- Volume: {backpack.Volume}/{backpack.MaxVolume}");
    Console.Write("\nYour choice:");
    if (!int.TryParse(Console.ReadLine(), out choice) || (choice < 0) || (choice > 6))
    {
        Console.WriteLine("Wrong input!. Try again.\n");
    }
    else
    {
        if (choice == 0)
            return;

        InventoryItem item = choice switch
        {
            1 => new Arrow(),
            2 => new Bow(),
            3 => new Rope(),
            4 => new Water(),
            5 => new FoodRations(),
            6 => new Sword(),
            _ => null
        };

        if (!backpack.Add(item))
            Console.WriteLine("That item won't fit in your pack.");
        else
            Console.WriteLine("Item added!");
    }
}