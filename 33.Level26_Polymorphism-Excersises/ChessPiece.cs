using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _33.Level26_Polymorphism_Excersises
{
    public class ChessPiece
    {
        public int Row { get; set; }
        public int Column { get; set; }

        //check if the new position is within the bounds of the chessboard and not the same as the current position of the piece
        public virtual bool IsMoveLegal(int newRow, int newColumn) =>
            IsOnBoard(newRow, newColumn) && !IsCurrentLocation(newRow, newColumn);

        //check if the new position is within the bounds of the chessboard (0-7 for both row and column)
        protected bool IsOnBoard(int row, int column) => row >= 0 && row < 8 && column >= 0 && column < 8;

        //check if the new position is the same as the current position of the piece
        protected bool IsCurrentLocation(int row, int column) => row == Row && column == Column;
    }
}