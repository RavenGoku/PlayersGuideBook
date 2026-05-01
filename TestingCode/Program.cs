



int AskForNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= min && number <= max)
        {
            return number;
        }
        Console.WriteLine("Number is out of range, please try again!");
    }
}


