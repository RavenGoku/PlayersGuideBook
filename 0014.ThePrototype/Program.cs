// See https://aka.ms/new-console-template for more information

/*
=========================== { The Prototype } ============================

Mylara, the captain of the Guard of Consolas, has approached you with the beginnings of a plan to hunt
down The Uncoded One’s airship. “If we’re going to be able to track this thing down,” she says, “we need
you to make us a program that can help us home in on a location.” She lays out a plan for a program to
help with the hunt. One user, representing the airship pilot, picks a number between 0 and 100. Another
user, the hunter, will then attempt to guess the number. The program will tell the hunter that they
guessed correctly or that the number was too high or low. The program repeats until the hunter guesses
the number correctly. Mylara claims, “If we can build this program, we can use what we learn to build a
better version to hunt down the Uncoded One’s airship.”

Objectives:
    •Build a program that will allow a user, the pilot, to enter a number.
    •If the number is above 100 or less than 0, keep asking.
    •Clear the screen once the program has collected a good number.
    •Ask a second user, the hunter, to guess numbers.
    •Indicate whether the user guessed too high, too low, or guessed right.
    •Loop until they get it right, then end the program.

 */

Console.Title = " The Prototype";
int inputNumber=0;
int hunterNumber=0;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber < 0 || inputNumber > 100)
    {
        Console.WriteLine("User 1, You typed wrong number, try again!");
        Console.WriteLine();
        continue;
    }
  
        Console.Clear();
        Console.Write("Hunter, try to guess the number User 1 type in: ");
    
    do
    {
        hunterNumber = Convert.ToInt32(Console.ReadLine());
        if (hunterNumber > inputNumber)
        {
            Console.WriteLine($"{hunterNumber} is too high.");
            Console.Write("What is your next guess? ");
            continue;
        }else if (hunterNumber < inputNumber)
        {
            Console.WriteLine($"{hunterNumber} is too low.");
            Console.Write("What is your next guess? ");
            continue;
        }
        else
        {
            Console.WriteLine($"Congratulation! You guessed the number!");
        }

    } while (inputNumber != hunterNumber);

    break;
} while(true);
