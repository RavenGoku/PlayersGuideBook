using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using Level24_TheCatacombsOfTheClass;


//Console.WriteLine("============================== Point Class ==============================\n");
//// Point class is defined in the Level24_TheCatacombsOfTheClass namespace,
//// so we need to include that namespace in our Program.cs file.
//Point point1 = new Point(2, 3);
//Point point2 = new Point(-4, 0);

//Console.WriteLine($"Point 1 ({point1.X},{point1.Y}); Point 2 ({point2.X},{point2.Y})");


//Console.WriteLine("============================== Color Class ==============================\n");
////Color class is defined in the Level24_TheCatacombsOfTheClass namespace
//Color newColor = new Color(158, 245, 65);
//Color orange = Color.Orange;

//Console.WriteLine(
//    $"Color created by constructor newColor R:{newColor.RedChannel}, G:{newColor.GreenChannel}, B:{newColor.BlueChannel}");
//Console.WriteLine(
//    $"Color created by pre-define property orange R:{orange.RedChannel}, G:{orange.GreenChannel}, B:{orange.BlueChannel}");


//Console.WriteLine("============================== Card Class ==============================\n");
////Card class is defined in the Level24_TheCatacombsOfTheClass namespace
//Card[] deckOfCards = CreateDeck();

//// Loop through the deck of cards and print out the color and rank of each card
//foreach (Card card in deckOfCards)
//{
//    Console.WriteLine($"Card:{card.Color}, {card.Rank}");
//}

//// CreateDeck method creates a deck of cards with 4 colors and 14 ranks
//Card[] CreateDeck()
//{
//    // Get the number of card colors and ranks from the CardColor and CardRank enums
//    int cardColorIndex = Enum.GetNames(typeof(CardColor)).Length;
//    int cardRankIndex = Enum.GetNames(typeof(CardRank)).Length;
//    int CalculateDeckSize = cardColorIndex * cardRankIndex;

//    // Create an array of Card objects to hold the deck of cards
//    Card[] suitCards = new Card[CalculateDeckSize];
//    int card = 0;

//    // Loop through the card colors and ranks to create a deck of cards
//    for (int i = 1; i <= cardColorIndex; i++)
//    {
//        for (int j = 1; j <= cardRankIndex; j++)
//        {
//            suitCards[card] = new Card((CardColor)i, (CardRank)j);
//            card++;
//        }
//    }

//    return suitCards;
//}

////======================== End Card Class =========================

Console.WriteLine("============================== Door Class ==============================");
Door door = CreateDoor();
Console.WriteLine($"Doors are {door.CurrentState}\n");

while (true)
{
    Console.WriteLine($"What would you like to do?");
    Console.Write($"Input Open,Close,Lock, Unlock, Change Passcode or exit: ");
    string? input = Console.ReadLine();
    DoorState response = input.ToLower() switch
    {
        "open" => door.Open(),
        "close" => door.Close(),
        "lock" => door.Lock(),
        "unlock" => door.Unlock(PromptForUnlock("Enter passcode to unlock")),
        _ => door.CurrentState
    };
    if (input.ToLower() == "change passcode")
    {
        door.PasscodeChange(PromptForUnlock("Enter current passcode"),
            PromptForUnlock("Enter new passcode"));
    }

    if (input == "exit") break;
    Console.Clear();
    Console.WriteLine($"The Door is {door.CurrentState}\n");
}

ulong PromptForUnlock(string message)
{
    ulong passcodeResult;
    bool isValid = false;
    do
    {
        Console.Write($"{message}: ");
        string input = Console.ReadLine();
        isValid = ulong.TryParse(input, out passcodeResult);

        if (!isValid)
        {
            Console.WriteLine("Numeric passcode only");
        }
    } while (!isValid);

    return passcodeResult;
}

Door CreateDoor()
{
    ulong passcode;
    bool isValid = false;
    do
    {
        Console.Write("Create passcode for you door: ");
        string input = Console.ReadLine();
        isValid = ulong.TryParse(input, out passcode);
        if (!isValid)
        {
            Console.WriteLine("Only numeric values!");
        }
        else
        {
            Console.WriteLine("Door and passcode created.");
        }
    } while (!isValid);

    return new Door(passcode);
}


Console.WriteLine("\n");