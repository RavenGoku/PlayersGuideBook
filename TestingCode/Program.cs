using System.Drawing;

Console.Title = "Classes";

Rectangle rectangle = new Rectangle(2, 3);

Console.WriteLine($"Rectangle area = {rectangle.GetArea()} cm.");

rectangle.SetWidth( 7 );
rectangle.SetHeight( 4 );

Console.WriteLine($"Rectangle area after change = {rectangle.GetArea()} cm.");



public class Rectangle
{
    private float _height;
    private float _width;

    public Rectangle (float width, float height)
    {
        _height = height;
        _width = width;
        
    }

    // Method expression (inline)
    public float GetHeight() => _height;
    //  same as normal method:
    //  public float GetHeight() 
    //  {
    //        return _height;
    //  }
    public float GetWidth() => _width;
    public float GetArea() => (_height * _width);

    public void SetHeight(float value ) => _height = value;
    public void SetWidth(float value) => _width = value;
}