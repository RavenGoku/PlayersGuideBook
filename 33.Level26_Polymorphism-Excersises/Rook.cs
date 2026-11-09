using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _33.Level26_Polymorphism_Excersises
{
    public class Rook : ChessPiece
    {
        public new bool IsMoveLegal(int newRow, int newColumn)
        {
            return true;
        }
    }
}