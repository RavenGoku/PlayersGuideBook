Rectangle rect = new Rectangle(2, 3);

Console.WriteLine($"Rectangle area of {rect.Width}x{rect.Height} is: {rect.Area}");

Circle circle = new Circle { X = 5, Y = 10, Radius = 3 };


//========================= Classes and Supports =========================

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
}
//-------------------------- End Class Rectangle --------------------------

//-------------------------- Class Player --------------------------
//class representing a player with a name property.
//Only the name can be set through the constructor, and it is read-only afterward.
public class Player
{
    //field to hold the name of the player, which is set through the constructor and cannot be changed afterward.
    private readonly string _name;
    public string Name { get; } = "Player1";

    //Constructor only allows setting the name of the player when creating an instance of the class.
    public Player(string name)
    {
        Name = name;
    }
}
//-------------------------- End Class Player --------------------------

//-------------------------- Class Circle --------------------------
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


//========================= End Classes and Supports =========================