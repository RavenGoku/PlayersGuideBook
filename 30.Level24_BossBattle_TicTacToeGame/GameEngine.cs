using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    internal class GameEngine
    {
        public static void Run()
        {
            UserInterface.Title();
            UserInterface.TutorialMessage();

            while (true)
            {
                Console.Write("Would you like to start? (y/n): ");
                string? startGame = Console.ReadLine()?.ToUpper();

                if (startGame == "N")
                {
                    Console.WriteLine("Exiting Game.");
                    return;
                }
                else if (startGame == "Y")
                    break;

                Console.WriteLine("invalid input. Please try Y or N");
            }

            //Create two players and ask for their names and symbols
            string playerName = UserInterface.AskForPlayerName(1);
            PlayerSymbol symbol = UserInterface.AskForPlayerSymbol();
            Player playerOne = new Player(playerName, symbol, ConsoleColor.DarkGreen);


            playerName = UserInterface.AskForPlayerName(2);
            symbol = symbol == PlayerSymbol.O ? PlayerSymbol.X : PlayerSymbol.O;

            Player playerTwo = new Player(playerName, symbol, ConsoleColor.Cyan);

            // Create a new instance of the Board class


            // Start the game loop
            string? playAgain;
            do
            {
                Console.Clear();
                Board board = new Board();
                RoundResult isWinOrDraw = RoundResult.None;

                UserInterface.Title();
                UserInterface.Display(playerOne, playerTwo, board);


                Console.Write($"Which player starts? ({playerOne.Name} 1 or {playerTwo.Name} 2): ");
                string? playerStart = Console.ReadLine();
                while (playerStart != "1" && playerStart != "2")
                {
                    Console.Write("Invalid input! Try 1 or 2: ");
                    playerStart = Console.ReadLine();
                }

                Player currentPlayer = playerStart == "1" ? playerOne : playerTwo;


                while (true)
                {
                    PlaceSymbolResult result = board.TryPlaceSymbol(UserInterface.AskPlayerForSquare(currentPlayer), (char)currentPlayer.Symbol);
                    while (result == PlaceSymbolResult.OutOfRange || result == PlaceSymbolResult.SquareNotAvailable)
                    {
                        Console.WriteLine($"{result}. Please choose another square.");
                        result = board.TryPlaceSymbol(UserInterface.AskPlayerForSquare(currentPlayer), (char)currentPlayer.Symbol);
                    }

                    if (board.IsGameWon((char)currentPlayer.Symbol))
                    {
                        if (currentPlayer == playerOne)
                        {
                            playerOne.Wins++;
                            playerTwo.Losses++;
                        }
                        else
                        {
                            playerTwo.Wins++;
                            playerOne.Losses++;
                        }

                        isWinOrDraw = RoundResult.Win;
                        break;
                    }

                    if (board.IsGameDraw())
                    {
                        playerOne.Draws++;
                        playerTwo.Draws++;
                        isWinOrDraw = RoundResult.Draw;
                        break;
                    }

                    Console.Clear();
                    UserInterface.Title();
                    UserInterface.Display(playerOne, playerTwo, board);

                    currentPlayer = currentPlayer == playerOne ? playerTwo : playerOne;
                }


                Console.Clear();
                UserInterface.Title();
                UserInterface.Display(playerOne, playerTwo, board);

                if (isWinOrDraw == RoundResult.Win)
                {
                    UserInterface.DisplayWinner(currentPlayer);
                }
                else if (isWinOrDraw == RoundResult.Draw)
                {
                    Console.WriteLine("It's a Draw!");
                }

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
            } while (playAgain == "Y");
        }
    }

    enum RoundResult { None, Win, Draw }
}