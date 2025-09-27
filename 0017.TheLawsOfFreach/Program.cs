// See https://aka.ms/new-console-template for more information

/*
=========================== { CHALLENGE TITLE } ============================

The town of Freach recently had an awful looping disaster. The lead investigator found that it was a faulty
++ operator in an old for loop, but the town council has chosen to ban all loops but the foreach loop.
Yet Freach uses the code presented earlier in this level to compute the minimum and the average value
in an int array. They have hired you to rework their existing for-based code to use foreach loops
instead.

Objectives:
    •Start with the code for computing an array’s minimum and average values in the section Some Examples with Arrays, starting on page 94.
    •Modify the code to use foreach loops instead of for loops.

 */

int[] array = new int[] { 4, -51, -7, 13, 2, -99, 15, -3, 45, 90, -102, 202, -5 };
int currentSmalest = int.MaxValue;
foreach(int number in array)
{
    if (number < currentSmalest)
    {
        currentSmalest = number;
    }
}
Console.WriteLine($"Current smallest number is {currentSmalest}");

int total = 0;
foreach(int number in array)
{
    total += number;
}
float average = (float)total/array.Length;
Console.WriteLine($"Average number is {average}");



