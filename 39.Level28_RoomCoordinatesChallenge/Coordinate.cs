using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace RoomCoordinates
{
    public readonly struct Coordinate(int row, int column)
    {
        public int Row { get; } = row;
        public int Column { get; } = column;

        public bool IsAdjacent(Coordinate otherRoom)
        {
            if (Math.Abs(otherRoom.Row - Row) == 1 && Math.Abs(otherRoom.Column - Column) == 0) return true;
            if (Math.Abs(otherRoom.Column - Column) == 1 && Math.Abs(otherRoom.Row - Row) == 0) return true;


            return false;
        }
    }
}