// See https://aka.ms/new-console-template for more information

/*
=========================== { The Defense of Consolas } ============================

The Uncoded One has begun an assault on the city of Consolas; the situation is dire. From a moving airship called the Manticore,
massive fireballs capable of destroying city blocks are being catapulted into the city.
The city is arranged in blocks, numbered like a chessboard.
The city’s only defense is a movable magical barrier, operated by a squad of four that can protect a single city block by putting
themselves in each of the target’s four adjacent blocks, as shown in the picture to the right.
For example, to protect the city block at (Row 6, Column 5), the crew deploys themselves to (Row 6, Column 4), (Row 5, Column 5),
(Row 6, Column 6), and (Row7, Column 5).
The good news is that if we can compute the deployment locations fast enough, the crew can be deployed around the target in time to prevent 
catastrophic damage to the city for as long as the siege lasts. The City of Consolas needs a program to tell the squad where to deploy, 
given the anticipated target. 
Something like this:
Target Row? 6
Target Column? 5
Deploy to:
(6, 4)
(5, 5)
(6, 6)
(7, 5)
Objectives:
    •Ask the user for the target row and column.
    •Compute the neighboring rows and columns of where to deploy the squad.
    •Display the deployment instructions in a different color of your choosing.
    •Change the window title to be “Defense of Consolas”.
    •Play a sound with Console.Beep when the results have been computed and displayed. 

 */

Console.Title = "Defense of Consolas";
int row = 0;
int column = 0;

Console.WriteLine("=========================== { The Defense of Consolas } ============================");

Console.Write("Target Row? ");
row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to:");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"({row},{--column})");
Console.Beep(500, 700); 

Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"({--row},{++column})");
Console.Beep(500, 700);

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"({++row},{++column})");
Console.Beep(500, 700);

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine($"({++row},{--column})");
Console.Beep(500, 700);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

