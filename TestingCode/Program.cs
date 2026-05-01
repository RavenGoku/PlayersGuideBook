Console.Title = "Tuples";


(double X, double Y) point = (2.0, 4.0);


var world = (Row: point.X, Column: point.Y, TileType.Grass);

double x = 0;
double y = 0;
TileType tt;


(x, y, tt) = world;


Console.WriteLine($"x = {x}, y = {y}, tile = {tt}");


























//=================================== Methods ================================================
void Display_Scores((string name, int level, int points) score)
{
    Console.WriteLine($"Name:{score.name}, Level:{score.level}, Score:{score.points}");
}
(string Name, int Point, int Level)[] CreateHighScores()
{
    return new (string, int, int)[3]
    {
        ("R2-D2", 12420, 15),
        ("C-3PO", 8435, 9),
        ("GONK", -1, 1),
    };
}

//================================ End Methods ===============================================
//================================ Classes     ===============================================
enum TileType { Grass, Water, Rock };






