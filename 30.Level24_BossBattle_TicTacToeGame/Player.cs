using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace TicTacToeGame
{
    internal class Player
    {
        public PlayerSymbol Symbol { get; init; }
        public string Name { get; init; }
        public ConsoleColor PlayerColor { get; init; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public Player() : this("Player", PlayerSymbol.O, ConsoleColor.White)
        {
        }

        public Player(string name, PlayerSymbol newSymbol, ConsoleColor newColor)
        {
            this.Name = name;
            this.Symbol = newSymbol;
            this.PlayerColor = newColor;
            Wins = 0;
            Losses = 0;
            Draws = 0;
        }
    }

    // Enum to represent player symbols
    public enum PlayerSymbol { O = 'O', X = 'X' };
}