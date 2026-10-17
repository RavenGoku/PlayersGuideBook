/* ------------------ Room Coordinates Challenge ------------------
                         Level 28 - Structs
                              50 XP

   The time to enter the Fountain of Objects draws closer.

   Ancient scrolls describe an area consisting of rooms arranged
   in a grid. Each room's location can be represented by a row
   and a column.

   Your task is to model these coordinates using a struct.

   Objectives:
   1. Create a Coordinate struct representing a room's
      position using a row and a column.

   2. Ensure that Coordinate is immutable.

   3. Create a method that determines whether two coordinates
      are adjacent (differing by exactly one row or one column).

   4. In Program.cs, create several coordinates and test
      whether they are adjacent to one another.

   ---------------------------------------------------------------
*/


using RoomCoordinates;

int gridSize = Grid(3);
int sideLength = (int)Math.Sqrt(gridSize);
Coordinate currentRoom = new Coordinate(1, 1);

Coordinate[] rooms = new Coordinate[gridSize];

for (int array = 0, row = 0, column = 0; array < rooms.Length;)
{
    for (; row < sideLength && array < rooms.Length; ++row)
    {
        for (; column < sideLength && array < rooms.Length; ++column)
        {
            rooms[array] = new Coordinate(row, column);
            array++;
        }

        column = 0;
    }
}

foreach (Coordinate room in rooms)
{
    Console.WriteLine(currentRoom.IsAdjacent(room));
}


//----------------------------------------------------
int Grid(int size)
{
    return size * size;
}