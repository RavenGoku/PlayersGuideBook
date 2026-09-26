using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToeGame
{
    internal class Board
    {
        private int AvailableSquaresCount { get; set; }
        public int AvailableSquares => AvailableSquaresCount;

        public char[] SquareSpaces { get; set; }

        //ctor
        public Board()
        {
            SquareSpaces = new char[9];
            for (int i = 0; i < SquareSpaces.Length; i++)
            {
                SquareSpaces[i] = ' ';
            }

            AvailableSquaresCount = SquareSpaces.Length;
        }


        public bool IsGameWon(char playerSymbol)
        {
            if (SquareSpaces[0] == playerSymbol && SquareSpaces[1] == playerSymbol && SquareSpaces[2] == playerSymbol)
                return true;
            else if (SquareSpaces[3] == playerSymbol && SquareSpaces[4] == playerSymbol &&
                     SquareSpaces[5] == playerSymbol)
                return true;
            else if (SquareSpaces[6] == playerSymbol && SquareSpaces[7] == playerSymbol &&
                     SquareSpaces[8] == playerSymbol)
                return true;
            else if (SquareSpaces[0] == playerSymbol && SquareSpaces[3] == playerSymbol &&
                     SquareSpaces[6] == playerSymbol)
                return true;
            else if (SquareSpaces[1] == playerSymbol && SquareSpaces[4] == playerSymbol &&
                     SquareSpaces[7] == playerSymbol)
                return true;
            else if (SquareSpaces[2] == playerSymbol && SquareSpaces[5] == playerSymbol &&
                     SquareSpaces[8] == playerSymbol)
                return true;
            else if (SquareSpaces[0] == playerSymbol && SquareSpaces[4] == playerSymbol &&
                     SquareSpaces[8] == playerSymbol)
                return true;
            else if (SquareSpaces[2] == playerSymbol && SquareSpaces[4] == playerSymbol &&
                     SquareSpaces[6] == playerSymbol)
                return true;
            else
                return false;
        }

        public bool IsGameDraw()
        {
            if (AvailableSquaresCount == 0)
                return true;

            return false;
        }

        //Valid Square is different than number, to assign to X or O,
        public bool IsSquareAvailable(char BoardSquare)
        {
            if (char.IsSeparator(BoardSquare))
                return true;

            return false;
        }

        public bool IsNumberWithinRange(int squareNumber)
        {
            if (squareNumber > 0 && squareNumber <= SquareSpaces.Length)
                return true;

            return false;
        }

        //Place number where to put Player's symbol. squareNumber - 1 due to index in arrays starts form 0
        public PlaceSymbolResult TryPlaceSymbol(int squareNumber, char playerSymbol)
        {
            if (!IsNumberWithinRange(squareNumber))
                return PlaceSymbolResult.OutOfRange;

            if (!IsSquareAvailable(SquareSpaces[squareNumber - 1]))
                return PlaceSymbolResult.SquareNotAvailable;

            SquareSpaces[squareNumber - 1] = playerSymbol;
            AvailableSquaresCount--;
            return PlaceSymbolResult.Success;
        }
    }

    enum PlaceSymbolResult
    {
        Success,
        OutOfRange,
        SquareNotAvailable
    }
}