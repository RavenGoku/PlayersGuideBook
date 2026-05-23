



Console.Title = "Tuples";




(double x, double y) points = (2.0, 4.0);



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
 enum TileType { Grass,Water,Rock,Fire}





