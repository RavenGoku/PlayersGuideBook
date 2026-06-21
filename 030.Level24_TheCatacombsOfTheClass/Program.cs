using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using Level24_TheCatacombsOfTheClass;

// Point class is defined in the Level24_TheCatacombsOfTheClass namespace, so we need to include that namespace in our Program.cs file.
Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"Point 1 ({point1.X},{point1.Y}); Point 2 ({point2.X},{point2.Y})");


//Color class is defined in the Level24_TheCatacombsOfTheClass namespace
Color newColor = new Color(158, 245, 65);
Color orange = Color.Orange;

Console.WriteLine(newColor.BlueChannel);


//Card class is defined in the Level24_TheCatacombsOfTheClass namespace
Card[] deckOfCards = CreateDeck();

// Loop through the deck of cards and print out the color and rank of each card
foreach (Card card in deckOfCards)
{
    Console.WriteLine($"Card:{card.Color}, {card.Rank}");
}

// CreateDeck method creates a deck of cards with 4 colors and 14 ranks
Card[] CreateDeck()
{
    Card[] suitCards = new Card[56];
    int i = 0;


    for (int cardColorIndex = 1; cardColorIndex <= 4; cardColorIndex++)
    {
        for (int cardRankIndex = 1; cardRankIndex <= 14; cardRankIndex++)
        {
            suitCards[i] = new Card((CardColor)cardColorIndex, (CardRank)cardRankIndex);
            i++;
        }
    }

    return suitCards;
}