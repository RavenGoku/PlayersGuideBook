using System;
using System.Collections.Generic;
using System.Text;

namespace _33.Level26_Polymorphism_Excersises
{
    public class Pawn : ChessPiece
    {
        public override bool IsMoveLegal(int newRow, int newColumn)
        {
            if (!base.IsMoveLegal(newRow, newColumn)) return false;
            if (newRow < Row || Math.Abs(newRow - Row) > 1) return false;


            return true;
        }
    }
}