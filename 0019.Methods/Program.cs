Console.WriteLine("Hello, World!");

CountToTen();
Count(4);


/// <summary>
/// Count to ten, starting from 1 to 10
/// </summary>
void CountToTen()
{
    for (int current = 1; current <= 10; current++)
    {
        Console.WriteLine(current);

    }
}


void Count(int numberToCountTo)
{
    for (int current = 1; current <= numberToCountTo; current++)
    {
        Console.WriteLine(current);
    }
}