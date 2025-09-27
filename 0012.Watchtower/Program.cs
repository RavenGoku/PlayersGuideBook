// See https://aka.ms/new-console-template for more information

/*
=========================== { Watchtower } ============================

There are watchtowers in the region around Consolas that can alert
you when an enemy is spotted. With some help from you, they can tell
you which direction the enemy is from the watchtower.
Objectives:
    •Ask the user for an x value and a y value. These are coordinates of the enemy 
     relative to the watchtower’s location.
    •Using the image on the right, if statements, and relational operators, display a message about what direction the enemy is
     coming from. For example, “The enemy is to the northwest!” or “The enemy is here!” 

 */

//gpt help me out with first objective naming only, i've got the code 
using System.Xml.Serialization;

int x=0,
    y=0;

// Prompt the user for x and y coordinates
Console.Write("Enter the x coordinate of the enemy: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the y coordinate of the enemy: ");
y = Convert.ToInt32(Console.ReadLine());

string response = "";

if (x<0)
{
    if (y > 0 || y < 0)
    {
        response = y > 0 ? "The enemy is to the northwest!" : "The enemy is to the southwest";
    } 
    else if (y == 0)
    {
        response = "The enemy is to the west!";
    }

}else if (x == 0)
{
    if (y > 0 || y < 0)
    {
        response = y > 0 ? "The enemy is to the north!" : "The enemy is to the south";
    }
    else if (y == 0)
    {
        response = "The enemy is Here!";
    }
    
}else if (x > 0)
{
    if (y > 0 || y < 0)
    {
        response = y > 0 ? "The enemy is to the northeast!" : "The enemy is to the southeast";

    }
    else if (y == 0)
    {
        response = "The enemy is to the east!";

    }
}
Console.WriteLine(response);

