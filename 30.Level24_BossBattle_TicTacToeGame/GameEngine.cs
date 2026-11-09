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

            if (UserInterface.GameStartingQuestion() == "N")
                return;


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
                Player currentPlayer = UserInterface.PlayerChoice(playerOne, playerTwo);


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
                            playerOne.AddWin();
                            playerTwo.AddLose();
                        }
                        else
                        {
                            playerOne.AddLose();
                            playerTwo.AddWin();
                        }

                        isWinOrDraw = RoundResult.Win;
                        break;
                    }

                    if (board.IsGameDraw())
                    {
                        playerOne.AddDraw();
                        playerTwo.AddDraw();
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

                playAgain = UserInterface.PlayAgain();
            } while (playAgain == "Y");
        }
    }

    enum RoundResult { None, Win, Draw }
}