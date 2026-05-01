// See https://aka.ms/new-console-template for more information

/*
=========================== { Taking a Number 100 XP } ============================

Many previous tasks have required getting a number from a user. To save time writing this code
repeatedly, you have decided to make a method to do this common task.

Objectives:

    •   Make a method with the signature int AskForNumber(string text). Display the text
    parameter in the console window, get a response from the user, convert it to an int, and return it.
    This might look like this: int result = AskForNumber("What is the airspeed velocity
    of an unladen swallow?");.

    •   Make a method with the signature int AskForNumberInRange(string text, int min, int
    max). Only return if the entered number is between the min and max values. Otherwise, ask again.

    •   Place these methods in at least one of your previous programs to improve it.

 */



//================== Functions ================================
/// <summary>
/// Ask user for a number, then wait for user's number input;
/// </summary>
int AskForNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
    ;

//-------------------------------------------------------------
int AskForNumberRange(string text, int min, int max)
{
    int number = 0;
    while (true)
    {
        number = AskForNumber(text);
        if (number < min) Console.WriteLine("Is not within the range, try again!");
        else if (number > max) Console.WriteLine("Is not within the range, try again!");
        else break;
    }
    return number;
}

//-------------------------------------------------------------


//=========================== Main ==================================
int inputNumber = AskForNumberRange("Player 1, input number between 0 and 100: ", 0, 100);
Console.Clear();

int guessNumber = AskForNumber("Player 2, try guess the number: ");
while (true)
{
    if (guessNumber < inputNumber) Console.WriteLine($"{guessNumber} is too low.");
    else if (guessNumber > inputNumber) Console.WriteLine($"{guessNumber} is too high.");
    else
    {
        Console.WriteLine("Congratulation! You guessed the number!");
        break;
    }
    guessNumber = AskForNumber("Try again: ");
}
