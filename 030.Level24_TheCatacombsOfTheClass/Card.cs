using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Level24_TheCatacombsOfTheClass
{
    internal class Card
    {
        public CardColor Color { get; init; }
        public CardRank Rank { get; init; } = 0;

        public string FaceCard
        {
            get
            {
                //cast the enum to an int and check if it is less than or equal to 10
                if ((int)(Rank) <= 10)
                {
                    return "Number Card";
                }
                else
                {
                    return "Symbol Card";
                }
            }
        }

        public Card() : this(CardColor.Red, CardRank.One)
        {
        }

        public Card(CardColor color, CardRank rank)
        {
            Color = color;
            Rank = rank;
        }
    }

    public enum CardColor { Red = 1, Green, Blue, Yellow };

    public enum CardRank
    {
        One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand
    }
}