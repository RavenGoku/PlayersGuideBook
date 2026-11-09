using System;
using System.Collections.Generic;
using System.Text;

namespace _44.Level31_FountainOfObjects_Challenge
{
    /// <summary>
    /// The Board class represents the game board, which is a grid of rooms.
    /// </summary>
    internal class Board
    {
        private Room[,] Rooms { get; }

        public Board()
        {
            Rooms = new Room[3, 3];
            for (int i = 0; i < Rooms.GetLength(0); i++) // for now
            {
                for (int j = 0; j < Rooms.GetLength(1); j++)
                {
                    Rooms[i, j] = new Room();
                }
            }
        }
    }

    //TODO: Make a BoardSize enum to allow for different sized boards. This will be useful for future challenges.
    //enum BoardSize
    //{
    //    small,
    //    medium,
    //    large
    //};
}