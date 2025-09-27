// See https://aka.ms/new-console-template for more information


/*
=========================== { Hunting the Manticore 250 XP } ============================

The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be
destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your
programming skills will you have a chance to win this fight. You must build a program that allows one
user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
town.

The first user begins by secretly establishing how far the Manticore is from the city, in the range 0 to 100.
The program then allows a second player to repeatedly attempt to destroy the airship by picking the
range to target until either the city of Consolas or the Manticore is destroyed. In each attempt, the player
is told if they overshot (too far), fell short (not far enough), or hit the Manticore. The damage dealt to the
Manticore depends on the turn number. For most turns, 1 point of damage is dealt. But if the turn number
is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of
damage, and if it is a multiple of both 3 and 5, a mighty fire-electric blast deals 10 points of damage. The
Manticore is destroyed after taking 10 points of damage.

However, if the Manticore survives a turn, it will deal a guaranteed 1 point of damage to the city of
Consolas. The city can only take 15 points of damage before being annihilated.
Before a round begins, the user should see the current status: the current round number, the city’s health,
and the Manticore’s health.

A sample run of the program is shown below. The first player gets a chance to place the Manticore:

Player 1, how far away from the city do you want to station the Manticore? 32

At this point, the display is cleared, and the second player gets their chance:
Player 2, it is your turn.
-----------------------------------------------------------
STATUS: Round: 1 City: 15/15 Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 50
That round OVERSHOT the target.
-----------------------------------------------------------
STATUS: Round: 2 City: 14/15 Manticore: 10/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 25
That round FELL SHORT of the target.
-----------------------------------------------------------
STATUS: Round: 3 City: 13/15 Manticore: 10/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
-----------------------------------------------------------
STATUS: Round: 4 City: 12/15 Manticore: 7/10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
-----------------------------------------------------------
STATUS: Round: 5 City: 11/15 Manticore: 6/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
-----------------------------------------------------------
STATUS: Round: 6 City: 10/15 Manticore: 3/10
The cannon is expected to deal 3 damage this round.
Enter desired cannon range: 32
That round was a DIRECT HIT!
The Manticore has been destroyed! The city of Consolas has been saved!


Objectives:
    • Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15.
    The game starts at round 1.

    • Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen
    afterward.

    • Run the game in a loop until either the Manticore’s or city’s health reaches 0.

    • Before the second player’s turn, display the round number, the city’s health, and the Manticore’s
    health.

    • Compute how much damage the cannon will deal this round: 10 points if the round number is a
    multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to
    the player.

    • Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too
    far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected
    amount.

    • If the Manticore is still alive, reduce the city’s health by 1.
    • Advance to the next round.
    • When the Manticore or the city’s health reaches 0, end the game and display the outcome.
    • Use different colors for different types of messages.
    • Note: This is the largest program you have made so far. Expect it to take some time!
    • Note: Use methods to focus on solving one problem at a time.
    • Note: This version requires two players, but in the future, we will modify it to allow the computer
        to randomly place the Manticore so that it can be a single-player game.
 */

//=================== Functions ==============================

using System.Text;

/// <summary>
/// Ask user for a number, then wait for user's number input;
/// </summary>
int AskForNumber(string text)
{
    // Display the provided prompt message to the user
    Console.Write(text);

    // Read user input from the console and convert it to an integer
    int number = Convert.ToInt32(Console.ReadLine());

    // Return the entered integer value
    return number;
};

//-------------------------------------------------------------

int AskForNumberRange(string text, int min, int max)
{
    // Variable to store the entered number
    int number = 0;

    // Keep asking until the user enters a valid number within the range
    while (true)
    {
        // Call AskForNumber to get user input
        number = AskForNumber(text);

        // If the number is less than the allowed minimum, show an error message
        if (number < min)
            Console.WriteLine("Is not within the range, try again!");

        // If the number is greater than the allowed maximum, show an error message
        else if (number > max)
            Console.WriteLine("Is not within the range, try again!");

        // If the number is valid, break out of the loop
        else
            break;
    }

    // Return the valid number
    return number;
};

//-------------------------------------------------------------
/// <summary>
/// Cannon hit point calculation, calculates if cannon strenght is 10,3 or 1, depend of what round.
/// </summary>
int CannonHitPoint(int gRound)
{
        // If the Game Round is divisible by both 3 and 5 (i.e., by 15), 
        // return 10 points (a powerful combined blast).
        if (gRound % 3 == 0 && gRound % 5 == 0)
            return 10;

        // If the Game Round is divisible by either 3 or 5, 
        // return 3 points (a weaker single blast).
        else if (gRound % 3 == 0 || gRound % 5 == 0)
            return 3;

        // If the Game Round is divisible by neither 3 nor 5, 
        // return 1 point (a normal shot).
        else
            return 1;
};

//-------------------------------------------------------------
void DisplayStatus(int round,int cityMax,int cityHealth,int mantiMax, int mantiHealth)
{
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round}   City: {cityMax}/{cityHealth}   Manticore: {mantiMax}/{mantiHealth}");
    
}
//-------------------------------------------------------------
int CannonResolveShot(int manticoreRange, int manticoreMaxHealth, int cannonStr)
{
    int cannonRange = AskForNumber("Enter desired cannon range: ");
    if (cannonRange < manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ResetColor();

    }
    else if (cannonRange > manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.ResetColor();

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ResetColor();

        return manticoreMaxHealth -= cannonStr;
    }
    return manticoreMaxHealth;

}
//-------------------------------------------------------------
bool CheckEndGame(int city, int manticore)
{
    if (city < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lost! City has been destroyed by Uncoded One's Manticore!");
        Console.ResetColor();
        return true;
    }
    else if (manticore < 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulation! \nFlying Ship was destroyed! City has been saved from Uncoded One's Manticore!");
        Console.ResetColor();
        return true;

    }
    return false;
}
//=================== End Functions ==============================


int manticoreHealth = 10;
int manticoreMaxHealth = manticoreHealth;
int cityHealth = 15;
int cityMaxHealth = cityHealth;
int gameRound = 1;
int cannonStrength = 0;
bool isGameEnd = false;



int manticoreRange = AskForNumberRange("Player 1, choose the Manticore's distance from the city (0 to 100): ", 0, 100);
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");
while (isGameEnd == false)
{
    DisplayStatus(gameRound, cityMaxHealth, cityHealth, manticoreMaxHealth, manticoreHealth);
    cityMaxHealth--;
    
    cannonStrength = CannonHitPoint(gameRound);
    Console.WriteLine($"The cannon is expected to deal {cannonStrength} damage this round.");

    manticoreMaxHealth = CannonResolveShot(manticoreRange, manticoreMaxHealth, cannonStrength);

    isGameEnd = CheckEndGame(cityMaxHealth, manticoreMaxHealth);

    gameRound++;
}
