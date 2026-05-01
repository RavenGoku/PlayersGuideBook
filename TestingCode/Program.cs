// See https://aka.ms/new-console-template for more information


/*There are watchtowers in the region around Consolas that can alert
you when an enemy is spotted. With some help from you, they can tell
you which direction the enemy is from the watchtower.

Objectives:
• Ask the user for an x value and a y value. These are coordinates of
the enemy relative to the watchtower’s location.
• Using the image on the right, if statements, and relational
operators, display a message about what direction the enemy is
coming from. For example, “The enemy is to the northwest!” or
“The enemy is here!” */

using System;

int x_value, y_value;
string response = "";

Console.Write("Input X value:");
x_value = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y value:");
y_value = Convert.ToInt32(Console.ReadLine());



if (x_value == 0 && y_value == 0)
{
    response = "Enemy is here!";

}else if(x_value < 0)
{
    if (y_value > 0)
        response = "Enemy is to the northwest!";
    else if (y_value < 0)
        response = "Enemy is to the southwest!";
    else
        response = "Enemy is to the west!";
}else if (x_value > 0)
{
    if (y_value > 0)
        response = "Enemy is to the northeast!";
    else if (y_value < 0)
        response = "Enemy is to the southeast!";
    else
        response = "Enemy is to the east!";
}else // x == 0
{
    if (y_value > 0)
        response = "Enemy is to the north!";
    else if (y_value < 0)
        response = "Enemy is to the south!";
}

Console.WriteLine(response);

