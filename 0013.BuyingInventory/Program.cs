// See https://aka.ms/new-console-template for more information

/*
=========================== { Buying Inventory } ============================

It is time to resupply. A nearby outfitter shop has the supplies you need but is so disorganized that they
cannot sell things to you. “Can’t sell if I can’t find the price list,” Tortuga, the owner, tells you as he turns
over and attempts to go back to sleep in his reclining chair in the corner.
There’s a simple solution: use your programming powers to build something to report the prices of
various pieces of equipment, based on the user’s selection:

The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of? 2
Torches cost 15 gold.

You search around the shop and find ledgers that show the following prices for these items: Rope: 10
gold, Torches: 15 gold, Climbing Equipment: 25 gold, Clean Water: 1 gold, Machete: 20 gold, Canoe: 200
gold, Food Supplies: 1 gold.

Objectives:
    •Build a program that will show the menu illustrated above.
    •Ask the user to enter a number from the menu.
    •Using the information above, use a switch (either type) to show the item’s cost.

 */

//My Solution---------------------------------------------------

//Console.Title = "Buying Inventory";
//int choice = 0;
//int itemCost = 0;
//string ItemName = "";

//Console.Write("The following items are available:" +
//    "\n1 – Rope" +
//    "\n2 – Torches" +
//    "\n3 – Climbing Equipment" +
//    "\n4 – Clean Water" +
//    "\n5 – Machete" +
//    "\n6 – Canoe" +
//    "\n7 – Food Supplies" +
//    "\nWhat number do you want to see the price of? ");

//choice = Convert.ToInt16(Console.ReadLine());
//Console.Write("What is your name? ");

//string customerName = Console.ReadLine()?? string.Empty;

//   switch (choice)
//    {
//        case 1:
//            ItemName = "Rope";
//            itemCost = 10;
//            break;

//        case 2:
//            ItemName = "Torches";
//            itemCost = 15;
//            break;

//        case 3:
//            ItemName = "Climbing Equipment";
//            itemCost = 25;
//            break;

//        case 4:
//            ItemName = "Clean Water";
//            itemCost = 1;
//            break;

//        case 5:
//            ItemName = "Machete";
//            itemCost = 20;
//            break;

//        case 6:
//            ItemName = "Canoe";
//            itemCost = 200;
//            break;

//        case 7:
//            ItemName = "Food Supplies";
//            itemCost = 1;
//            break;
//    };

//if (customerName == "Goku")
//{
//    Console.WriteLine($"Because you are a Hero, You got 50% discount!");
//    Console.WriteLine($"{ItemName} cost {(double)itemCost / 2} gold.");
//}
//else
//{
//    Console.WriteLine($"{ItemName} cost {itemCost} gold.");
//};

//RB Solution -------------------------------------------------------------------------------------

Console.Write("The following items are available:" +
    "\n1 – Rope" +
    "\n2 – Torches" +
    "\n3 – Climbing Equipment" +
    "\n4 – Clean Water" +
    "\n5 – Machete" +
    "\n6 – Canoe" +
    "\n7 – Food Supplies" +
    "\nWhat number do you want to see the price of? ");

int itemNumber = Convert.ToInt32(Console.ReadLine());

string item;
item = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 16,
    "Climbing Equipment" => 24,
    "Clean Water" => 2,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 2
};

Console.Write("What is your name? ");
string name = Console.ReadLine();

if (name == "Goku") price /= 2;

Console.WriteLine($"{item} costs {price} gold.");