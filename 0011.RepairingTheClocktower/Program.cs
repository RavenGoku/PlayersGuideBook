// See https://aka.ms/new-console-template for more information

/*
=========================== { Repairing The Clocktower } ============================

The recent attacks damaged the great Clocktower of Consolas. The citizens of Consolas have repaired
most of it, except one piece that requires the steady hand of a Programmer. It is the part that makes the
clock tick and tock. Numbers flow into the clock to make it go, and if the number is even, the clock’s
pendulum should tick to the left; if the number is odd, the pendulum should tock to the right. Only a
programmer can recreate this critical clock element to make it work again.

Objectives:
    •Take a number as input from the console. 
    •Display the word “Tick” if the number is even. Display the word “Tock” if the number is odd.
    •Hint: Remember that you can use the remainder operator to determine if a number is even or odd.
 
 */

Console.Title = "RepairingTheClocktower";
int clockNumber;
double shield = 0,
       armor = 0;



Console.WriteLine("The recent attacks damaged the great Clocktower of Consolas. The citizens of Consolas have repaired" +
    "\r\nmost of it, except one piece that requires the steady hand of a Programmer. It is the part that makes the" +
    "\r\nclock tick and tock. Numbers flow into the clock to make it go, and if the number is even, the clock’s" +
    "\r\npendulum should tick to the left; if the number is odd, the pendulum should tock to the right. Only a" +
    "\r\nprogrammer can recreate this critical clock element to make it work again.");

Console.Write("\n\nInput clock number: ");
clockNumber = Convert.ToInt32(Console.ReadLine());
bool isEven = clockNumber % 2 == 0;


if (isEven)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

bool stillHasShields = shield > 0;
bool stillHasArmor = armor > 0;

if (shield <= 0)
{
    if (armor <= 0)
    {
        Console.WriteLine("Shield and Armor at zero! you're dead!");
    }
    else
    {
        Console.WriteLine("Shield gone but, armor is keeping you alive! Keep going!");
    }
}
else
    Console.WriteLine("You still have shields left. The world is safe!");