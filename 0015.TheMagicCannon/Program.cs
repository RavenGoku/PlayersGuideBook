// See https://aka.ms/new-console-template for more information

/*
=========================== { The Magic Cannon } ============================

Skorin, a member of Consolas’s wall guard, has constructed a magic cannon that draws power from two
gems: a fire gem and an electric gem. Every third turn of a crank, the fire gem activates, and the cannon
produces a fire blast. The electric gem activates every fifth turn of the crank, and the cannon makes an
electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to
produce a program that can warn the crew about which turns of the crank will produce the different
blasts before they do it.

Objectives:
    •Write a program that will loop through the values between 1 and 100 and display what kind of blast
    the crew should expect. (The % operator may be of use.)

    •Change the color of the output based on the type of blast. (For example, red for Fire, yellow for
    Electric, and blue for Electric and Fire).
 */

Console.Title = "The Magic Cannon";
Console.WriteLine("=================== The Magic Cannon ==============");

for (int crankTurn = 1; crankTurn <= 100; crankTurn++)
{

    if (crankTurn % 3 == 0 && crankTurn % 5 == 0)
    {

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{crankTurn}: Electric and Fire\n");

    }
    else if (crankTurn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{crankTurn}: Fire\n");
    }
    else if (crankTurn % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{crankTurn}: Electric\n");
    }
    else
    {
        Console.ResetColor();
        Console.Write($"{crankTurn}: Normal\n");
    }
    Console.ResetColor();

}


