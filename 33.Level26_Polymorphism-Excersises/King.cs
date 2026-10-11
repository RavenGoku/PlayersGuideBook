using System;
using System.Collections.Generic;
using System.Text;

namespace _33.Level26_Polymorphism_Excersises
{
    public class King : ChessPiece
    {
        public override bool IsMoveLegal(int newRow, int newColumn)
        {
            //Check if King's move is legal by checking if the new position is
            //within one square in any direction from the current position
            if (!base.IsMoveLegal(newRow, newColumn)) return false;
            if (Math.Abs(newRow - Row) > 1) return false;
            if (Math.Abs(newColumn - Column) > 1) return false;
            return true;
        }
    }
}