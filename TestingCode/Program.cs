


int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.

foreach( int small in array)
{
    if ( small < currentSmallest)
    {
        currentSmallest = small;
    }
}
Console.WriteLine("Smallest number in array is:" + currentSmallest);



//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
float average;

foreach (int number in array)
{
    total += number;
}

average = (float)total / array.Length;
Console.WriteLine($"Average number in array is: {average}");