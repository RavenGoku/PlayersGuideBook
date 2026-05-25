using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Markup;

Console.Title = "Classes";

Rectangle rectangle = new Rectangle(5, 3);

Console.WriteLine($"A {rectangle.Width} x {rectangle.Height} rectangle has an are of {rectangle.Area}. ");

Circle circle = new Circle() { Radius  = 5 , X = 4, Y = 2};




public class Circle
{
    public float X { get; init; } = 0;
    public float Y { get; init; } = 0;
    public float Radius { get; init; } = 0;
}
public class Player
{
    public string Name { get; init; } = "Kakarotto";
    //ctor
    public Player()
    {
        Name = Name;
    }
}


public class Rectangle
{
    public float Width { get; set; }
    public float Height { get; set;  }
    //property that has get-only, we can simplify it to: 
    public float Area => (Height * Width);
    
    //ctor
    public Rectangle (float width, float height)
    {
        Height = height;
        Width = width;
    }

}