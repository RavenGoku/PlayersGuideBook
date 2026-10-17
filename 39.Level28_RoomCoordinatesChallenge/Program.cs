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

int rows = 3;
int columns = 4;
Coordinate currentRoom = new Coordinate(1, 1);

Coordinate[] rooms = new Coordinate[rows * columns];

int index = 0;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < columns; col++)
    {
        rooms[index] = new Coordinate(row, col);
        index++;
    }
}

foreach (Coordinate room in rooms)
{
    Console.WriteLine(currentRoom.IsAdjacent(room));
}