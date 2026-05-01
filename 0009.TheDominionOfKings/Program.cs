// See https://aka.ms/new-console-template for more information

/*
=========================== { The Dominion of Kings } ============================

Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom
among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree
to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every
duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow
them to enter their current holdings and compute a point total.

Objectives:
•   Create a program that allows users to enter how many provinces, duchies, and estates they have.
•   Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
•   Display the point total to the user.

 */

int estate = 1,
    duchy = 3,
    province = 6;

int input = 0;
int result = 0;

Console.WriteLine("=========================== { The Dominion of Kings } ============================\r\n" +
    "\r\nThree kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom" +
    "\r\namong them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree" +
    "\r\nto a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every" +
    "\r\nduchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow" +
    "\r\nthem to enter their current holdings and compute a point total.\n\n");



Console.Write("Input how many estates you have: ");
input = Convert.ToInt32(Console.ReadLine());
result += (estate * input);

Console.Write("Input how many duchies you have: ");
input = Convert.ToInt32(Console.ReadLine());
result += (duchy * input);

Console.Write("Input how many provinces you have: ");
input = Convert.ToInt32(Console.ReadLine());
result += (province * input);

Console.WriteLine("You gathered " + result + " points.");
