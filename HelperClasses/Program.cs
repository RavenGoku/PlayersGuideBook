Console.Title = "Helper Classes - C# 14.0";


//========================= Level 18 - Classes - Classes and Supports =========================

public class Score
{
    private string Name { get; init; } = "Player";
    private int Points { get; init; } = 0;
    private int Level { get; init; } = 0;

    public static readonly int PointThreshold;
    public static readonly int LevelThreshold;


    //constructor to initialize the Score object with name, points, and level.
    public Score(string name, int points, int level)
    {
        Name = name;
        Points = points;
        Level = level;
    }

    //Addition from Level 21 - Static, a static constructor to initialize the static readonly fields PointThreshold and LevelThreshold.
    static Score()
    {
        PointThreshold = 1000; // Example threshold for points
        LevelThreshold = 4; // Example threshold for levels
    }


    // Addition from Level 21 - Static, a static method to count the number of scores for a specific player in an array of Score objects.
    public static int CountForPayer(string playerName, Score[] scores)
    {
        int count = 0;
        foreach (Score s in scores)
        {
            if (s.Name == playerName) count++;
        }

        return count;
    }
}


//========================== End Level 18 - Classes - Classes and Supports ====================

//========================= Level 20 - Properties - Classes and Supports =========================

//-------------------------- Class Rectangle --------------------------
//Class representing a rectangle with width and height properties.
//Only the width and height can be set through the constructor, and they are read-only afterward.
//The area of the rectangle is calculated based on its width and height.

public class Rectangle
{
    //Constructor to initialize the rectangle with specified width and height.
    public Rectangle(float width, float height)
    {
        if (width > 0)
            Width = width;
        else
            Width = 1; // Default width if the provided width is not positive

        if (height > 0)
            Height = height;
        else
            Height = 1; // Default height if the provided height is not positive
    }

    public float Width { get; }
    public float Height { get; }
    public float Area => Width * Height;

    public static Rectangle CreateSquare(float size) => new Rectangle(size, size);
}
//-------------------------- End Class Rectangle -----------------------

//-------------------------- Class Player ------------------------------
//class representing a player with a name property.
//Only the name can be set through the constructor, and it is read-only afterward.
public class Player
{
    //field to hold the name of the player, which is set through the constructor and cannot be changed afterward.
    private readonly string _name = "Player";
    public string Name { get; } = "Player1";

    //Constructor only allows setting the name of the player when creating an instance of the class.
    public Player(string name)
    {
        Name = name;
    }
}
//-------------------------- End Class Player --------------------------

//-------------------------- Class Circle ------------------------------
public class Circle
{
    public float X { get; init; } =
        0; // initializer for X-coordinate of the circle's center, only settable during object initialization

    public float Y { get; init; } =
        0; // initializer for Y-coordinate of the circle's center, only settable during object initialization

    public float Radius { get; init; } =
        0; // initializer for the radius of the circle, only settable during object initialization
}
//-------------------------- End Class Circle --------------------------


//========================= End Level 20 - Properties - Classes and Supports =========================

//**********************************************************************************************************************

//========================= Level 21 - Static - Classes and Supports ==============================
//Static Class that provides utility methods for mathematical operations.
public static class Utilities
{
    public static int HelperMethod() => 1; // Static method that returns the integer 1
    public static double HelperProperty => 3.14; // Static property that returns the value of pi
    public static int AddNumbers(int a, int b) => a + b; // Static method that adds two integers and returns the result
}

//========================== End Level 21 - Static - Classes and Supports =========================

//**********************************************************************************************************************