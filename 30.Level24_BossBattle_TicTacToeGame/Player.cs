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
        private int Wins { get; set; }
        private int Losses { get; set; }
        private int Draws { get; set; }


        public Player(string name, PlayerSymbol newSymbol, ConsoleColor newColor)
        {
            this.Name = name;
            this.Symbol = newSymbol;
            this.PlayerColor = newColor;
            Wins = 0;
            Losses = 0;
            Draws = 0;
        }


        public void AddWin()
        {
            Wins++;
        }

        public void AddLose()
        {
            Losses++;
        }

        public void AddDraw()
        {
            Draws++;
        }

        public int GetWins()
        {
            return Wins;
        }

        public int GetLoses()
        {
            return Losses;
        }

        public int GetDraws()
        {
            return Draws;
        }
    }

    // Enum to represent player symbols

    public enum PlayerSymbol { O = 'O', X = 'X' };
}