// See https://aka.ms/new-console-template for more information

/*
=========================== { The Replicator Of D'To } ============================

While searching an abandoned storage building containing strange code artifacts, you uncover the
ancient Replicator of D’To. This can replicate the contents of any int array into another array. But it
appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.

Objectives:
    •Make a program that creates an array of length 5.
    •Ask the user for five numbers and put them in the array.
    •Make a second array of length 5.
    •Use a loop to copy the values out of the original array and into the new one.
    •Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
    again.

 */

Console.Title = "The Replicator of D'To";
int[] array = new int[5];
int[] replication_magic = new int[5];

//Ask the user for 5 numbers -------------------------------------------
Console.WriteLine("User, please input 5 numbers in the replicator.");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Input {i + 1} number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

// replicate the array ---------------------------------------------------
for (int i = 0; i < array.Length; i++)
{
    replication_magic[i] = array[i];
}
Console.WriteLine();

// Display original array ------------------------------------------------
Console.Write("Array: ");
foreach (int numbers in array)
{
    Console.Write(numbers + ", ");
}
Console.WriteLine();

// Display the replicated array ------------------------------------------------
Console.Write("Replicator array: ");
foreach (int numbers in replication_magic)
{
    Console.Write(numbers + ", ");
}
Console.WriteLine();