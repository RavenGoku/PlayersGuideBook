using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TicTacToeGame
{
    internal static class UserInterface
    {
        public static void Title()
        {
            string title = @"
*===============================================================================================*                                                                                                 
| $$$$$$$$\ $$\                 $$$$$$$$\                        $$$$$$$$\                      |  
| \__$$  __|\__|                \__$$  __|                       \__$$  __|                     | 
|    $$ |   $$\  $$$$$$$\          $$ | $$$$$$\   $$$$$$$\          $$ | $$$$$$\   $$$$$$\      |
|    $$ |   $$ |$$  _____|         $$ | \____$$\ $$  _____|         $$ |$$  __$$\ $$  __$$\     |
|    $$ |   $$ |$$ |               $$ |$$  __$$ |$$ |               $$ |$$ |  $$ |$$   ____|    |
|    $$ |   $$ |\$$$$$$$\          $$ |\$$$$$$$ |\$$$$$$$\          $$ |\$$$$$$  |\$$$$$$$\     |
|    \__|   \__| \_______|         \__| \_______| \_______|         \__| \______/  \_______|    |

*===============================================================================================*";

            Console.WriteLine(title);
        }

        public static void TutorialMessage()
        {
            Console.WriteLine($"Welcome to Tic Tac Toe!\n\n" +
                              $"HOW TO PLAY\n\n" +
                              $" 7 | 8 | 9 \n" +
                              $"---+---+---\n" +
                              $" 4 | 5 | 6 \n" +
                              $"---+---+---\n" +
                              $" 1 | 2 | 3 \n\n" +
                              $"Players take turns choosing an available square, from 1 - 9 correspond to numpad.\n" +
                              $"The first player to place three matching symbols in a row, column, or diagonal wins.\n" +
                              $"If all squares are filled without a winner, the game ends in a draw.\n\n");
        }

        public static string GameStartingQuestion()
        {
            string? startGame;
            while (true)
            {
                Console.Write("Would you like to start? (y/n): ");
                startGame = Console.ReadLine()?.ToUpper();

                if (startGame == "N")
                {
                    Console.WriteLine("Exiting Game.");
                    break;
                }
                else if (startGame == "Y")
                    break;

                Console.WriteLine("invalid input. Please try Y or N");
            }

            return startGame;
        }

        public static string AskForPlayerName(int playerNumber)
        {
            while (true)
            {
                Console.Write($"Enter the name for Player {playerNumber}: ");
                string? name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name) && name != " ")
                {
                    name.Trim();
                    return name;
                }


                Console.WriteLine("Invalid input. Please enter name.");
            }
        }

        public static PlayerSymbol AskForPlayerSymbol()
        {
            while (true)
            {
                Console.Write("Choose your symbol (X or O): ");
                string? symbol = Console.ReadLine()?.ToUpper();
                if (symbol == "O" || symbol == "X")
                {
                    return symbol == "O" ? PlayerSymbol.O : PlayerSymbol.X;
                }

                Console.WriteLine("You didn't choose a valid symbol, try again.");
            }
        }

        public static Player PlayerChoice(Player player1, Player player2)
        {
            Console.Write($"Which player starts? ({player1.Name} 1 or {player2.Name} 2): ");
            string? playerStart = Console.ReadLine();
            while (playerStart != "1" && playerStart != "2")
            {
                Console.Write("Invalid input! Try 1 or 2: ");
                playerStart = Console.ReadLine();
            }

            return playerStart == "1" ? player1 : player2;
        }

        public static void ShowBoard(Board board)
        {
            string boardString;

            // Create variables string board rows to create a 3x3 grid format
            string boardRow1 = $" {board.SquareSpaces[6]} | {board.SquareSpaces[7]} | {board.SquareSpaces[8]} ";
            string boardRow2 = $" {board.SquareSpaces[3]} | {board.SquareSpaces[4]} | {board.SquareSpaces[5]} ";
            string boardRow3 = $" {board.SquareSpaces[0]} | {board.SquareSpaces[1]} | {board.SquareSpaces[2]} ";

            // Create a line of dashes based on the width of the boardRow 
            int width = boardRow1.Length / 3;
            string line = new('-', width);
            line += new string("+");
            line += new string('-', width);
            line += new string("+");
            line += new string('-', width);
            // Create the board string with borders and lines


            boardString = $"{boardRow1}\n";
            boardString += $"{line}\n";
            boardString += $"{boardRow2}\n";
            boardString += $"{line}\n";
            boardString += $"{boardRow3}\n";


            // Display the board
            Console.WriteLine(boardString);
        }

        public static void Display(Player playerOne, Player playerTwo, Board board)
        {
            string playerOneInfo = $"{playerOne.Name} : {playerOne.Symbol} - Wins: {playerOne.GetWins()}, Losses: {playerOne.GetLoses()}, Draws: {playerOne.GetDraws()}";
            string playerTwoInfo = $"{playerTwo.Name} : {playerTwo.Symbol} - Wins: {playerTwo.GetWins()}, Losses: {playerTwo.GetLoses()}, Draws: {playerTwo.GetDraws()}";

            Console.ForegroundColor = playerOne.PlayerColor;
            Console.Write($"\n{playerOneInfo}");
            Console.ResetColor();
            Console.Write(" | ");

            Console.ForegroundColor = playerTwo.PlayerColor;
            Console.Write($"{playerTwoInfo}");
            Console.ResetColor();
            Console.WriteLine($"\n\n");


            ShowBoard(board);
        }

        public static int AskPlayerForSquare(Player player)
        {
            while (true)
            {
                Console.ForegroundColor = player.PlayerColor;
                Console.Write($"\n{player.Name}");
                Console.ResetColor();

                Console.Write($" chose square:");
                string? squareInput = Console.ReadLine();

                if (int.TryParse(squareInput, out int squareInputResult))
                {
                    return squareInputResult;
                }

                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }


        public static void DisplayWinner(Player player)
        {
            Console.ForegroundColor = player.PlayerColor;
            Console.Write($"\n\n{player.Name} ");
            Console.ResetColor();
            Console.WriteLine($"wins!");
        }

        public static string PlayAgain()
        {
            string playAgain;
            while (true)
            {
                Console.Write("Would you like to play again? (y/n): ");
                playAgain = Console.ReadLine()?.ToUpper();
                if (playAgain == "Y")
                {
                    break;
                }

                if (playAgain == "N")
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please input Y or N.");
            }

            return playAgain;
        }
    }
}