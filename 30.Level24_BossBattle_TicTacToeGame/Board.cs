using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToeGame
{
    internal class Board
    {
        private int AvailableSquaresCount { get; set; }
        public int AvailableSquares => AvailableSquaresCount;

        private char[] SquareSpaces { get; set; }

        //ctor
        public Board()
        {
            SquareSpaces = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            AvailableSquaresCount = SquareSpaces.Length;
        }

        public void ShowBoard()
        {
            string board;

            // Create variables string board rows to create a 3x3 grid format
            string boardRow1 = $" {SquareSpaces[6]} | {SquareSpaces[7]} | {SquareSpaces[8]} ";
            string boardRow2 = $" {SquareSpaces[3]} | {SquareSpaces[4]} | {SquareSpaces[5]} ";
            string boardRow3 = $" {SquareSpaces[0]} | {SquareSpaces[1]} | {SquareSpaces[2]} ";

            // Create a line of dashes based on the width of the boardRow 
            int width = boardRow1.Length / 3;
            string line = new string('-', width);
            line += new string("+");
            line += new string('-', width);
            line += new string("+");
            line += new string('-', width);
            // Create the board string with borders and lines


            board = $"{boardRow1}\n";
            board += $"{line}\n";
            board += $"{boardRow2}\n";
            board += $"{line}\n";
            board += $"{boardRow3}\n";


            // Display the board
            Console.WriteLine(board);
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
            if (char.IsNumber(BoardSquare))
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