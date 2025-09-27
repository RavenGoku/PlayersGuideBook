// See https://aka.ms/new-console-template for more information

/*
=========================== { The Variable Shop } ============================

You see an old shopkeeper struggling to stack up variables in a window display. “Hoo-wee! All these
variable types sure are exciting but setting them all up to show them off to excited new programmers
like yourself is a lot of work for these aching bones,” she says. “You wouldn’t mind helping me set up this
program with one variable of every type, would you?”

Objectives:
    •Build a program with a variable of all fourteen types described in this level.
    •Assign each of them a value using a literal of the correct type.
    •Use Console.WriteLine to display the contents of each variable.

 */

byte unsignedByte = 1;
ushort unsignedShort = 2;
uint unsignedInt = 3;
ulong unsignedLong = 4;

sbyte signedByte = -1;
short signedShort = -2;
int signedInt = -3;
long signedLong = -4;

float signedFloat = -5;
double signedDouble = -6;
decimal signedDecimal = -7;

bool trueFalse = false;

char aLetter = 'A';
string aWord = "Hello World";

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

