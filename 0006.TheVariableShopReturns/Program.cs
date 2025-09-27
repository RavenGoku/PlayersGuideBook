// See https://aka.ms/new-console-template for more information


/*
=========================== { The Variable Shop Returns } ============================

“Hey! Programmer!” It’s the shopkeeper from the Variable Shop who hobbles over to you. “Thanks to
your help, variables are selling like RAM cakes! But these people just aren’t any good at programming.
They keep asking how to modify the values of the variables they’re buying, and… well… frankly, I have no
clue. But you’re a programmer, right? Maybe you could show me so I can show my customers?”

Objectives:
    • Modify your Variable Shop program to assign a new, different literal value to each of the 14 original
     variables. Do not declare any additional variables.

    • Use Console.WriteLine to display the updated contents of each variable.
 */


byte unsignedByte = 10;
ushort unsignedShort = 22;
uint unsignedInt = 31;
ulong unsignedLong = 45;

sbyte signedByte = -12;
short signedShort = -211;
int signedInt = 33;
long signedLong = -124;

float signedFloat = 35;
double signedDouble = -346;
decimal signedDecimal = 7321;

bool trueFalse = true;

char aLetter = 'f';
string aWord = "The Variable Shop";


Console.WriteLine("unsignedByte = " + unsignedByte);
Console.WriteLine("unsignedShort = " + unsignedShort);
Console.WriteLine("unsignedInt = " + unsignedInt);
Console.WriteLine("unsignedLong = " + unsignedLong);

Console.WriteLine("signedByte = " + signedByte);
Console.WriteLine("signedShort = " + signedShort);
Console.WriteLine("signedInt = " + signedInt);
Console.WriteLine("signedLong = " + signedLong);

Console.WriteLine("signedFloat = " + signedFloat);
Console.WriteLine("signedDouble = " + signedDouble);
Console.WriteLine("signedDecimal = " + signedDecimal);

Console.WriteLine("trueFalse = " + trueFalse);

Console.WriteLine("aLetter = " + aLetter);
Console.WriteLine("aWord = " + aWord);