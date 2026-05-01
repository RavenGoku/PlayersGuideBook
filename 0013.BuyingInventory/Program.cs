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

/*My Solution---------------------------------------------------

double rope = 10,
    torches = 15,
    climbing_equipment = 25,
    clean_water = 1,
    machete = 20,
    canoe = 200,
    food_supplies = 1; 

double discount;

Console.WriteLine("Hello Customer, what's you're name? ");
string name = Console.ReadLine();

bool is_hero = name.Equals("Goku",StringComparison.OrdinalIgnoreCase);

discount = is_hero ? 0.5 : 1.0;

if(is_hero)
{
    Console.WriteLine($"Hero {name}? Then for you is 50% discount!");
}



Console.Write(@"The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
8 - exit
What number do you want to see the price of? ");
int new_choice = Convert.ToInt32(Console.ReadLine());

while (new_choice != 8)
{
    string response = "";
    
        response = new_choice switch
        {
            1 => $"Rope: {rope * discount} gold",
            2 => $"Torches: {torches * discount} gold",
            3 => $"Climbing Equipment: {climbing_equipment * discount} gold",
            4 => $"Clean Water: {clean_water * discount} gold",
            5 => $"Machete: {machete * discount} gold",
            6 => $"Canoe: { canoe * discount} gold",
            7 => $"Food Supplies: {food_supplies * discount } gold",
            _ => $"Unavailable at the moment."
        };
        Console.WriteLine(
            response + "\n");
        Console.Write("What number do you want to see the price of? ");
        new_choice = Convert.ToInt32(Console.ReadLine());
}
 */

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