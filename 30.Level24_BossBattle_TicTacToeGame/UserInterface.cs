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
                              $"   |   |   \n" +
                              $"---+---+---\n" +
                              $"   |   |   \n" +
                              $"---+---+---\n" +
                              $"   |   |   \n" +
                              $"Players take turns choosing an available square.\n" +
                              $"The first player to place three matching symbols in a row, column, or diagonal wins.\n" +
                              $"If all squares are filled without a winner, the game ends in a draw.\n\n");
        }

        public static void Display(Player playerOne, Player playerTwo, Board board)
        {
            string playerOneInfo = $"{playerOne.Name} : {playerOne.Symbol} - Wins: {playerOne.Wins}, Losses: {playerOne.Losses}, Draws: {playerOne.Draws}";
            string playerTwoInfo = $"{playerTwo.Name} : {playerTwo.Symbol} - Wins: {playerTwo.Wins}, Losses: {playerTwo.Losses}, Draws: {playerTwo.Draws}";

            Console.ForegroundColor = playerOne.PlayerColor;
            Console.Write($"\n{playerOneInfo}");
            Console.ResetColor();
            Console.Write(" | ");

            Console.ForegroundColor = playerTwo.PlayerColor;
            Console.Write($"{playerTwoInfo}");
            Console.ResetColor();
            Console.WriteLine($"\n\n");


            board.ShowBoard();
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

        public static string AskForPlayerName(int playerNumber)
        {
            while (true)
            {
                Console.Write($"Enter the name for Player {playerNumber}: ");
                string? name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name) && name != " ")
                    return name;

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

        public static void DisplayWinner(Player player)
        {
            Console.ForegroundColor = player.PlayerColor;
            Console.Write($"\n\n{player.Name} ");
            Console.ResetColor();
            Console.WriteLine($"wins!");
        }
    }
}