using System;
using System.Drawing;

/*
 * RECORDS — LEVEL 29
 *
 * A record is a special type in C# designed primarily
 * to represent and store data.
 *
 * Unlike regular classes, records provide built-in
 * value-based equality, meaning two records can be
 * considered equal when their corresponding values
 * are equal, even if they are separate objects.
 *
 * KEY FEATURES:
 *
 * 1. Records can be reference types (record class)
 *    or value types (record struct).
 *
 * 2. Records automatically provide value-based equality.
 *
 * 3. Records generate useful functionality, including
 *    ToString() and value-based GetHashCode().
 *
 * 4. Records support non-destructive mutation using
 *    the 'with' expression to create modified copies.
 *
 * 5. Positional records provide a concise way to declare
 *    data members using constructor-like syntax.
 *
 * 6. Records are not automatically immutable.
 *    Their mutability depends on how they are declared.
 *
 * MAIN PURPOSE:
 * Use records when the values stored in an object are
 * more important than its individual identity.
 *
 * REMEMBER:
 * class         -> Reference type, usually identity-based equality.
 * struct        -> Value type, value-based equality by default.
 * record        -> Reference type, value-based equality by default.
 * record struct -> Value type, value-based equality by default.
 */


//Records automatically override the ToString method with a convenient, readable
// representation of its data.
Console.WriteLine(new Point(2, 3).ToString()); //Point { X = 2, Y = 3 }


// Value semantics means comparing data rather than references.
// struct -> Value semantics by default.
// class  -> Reference semantics by default.
// record -> Value semantics by default.
// Records automatically implement value-based equality
// through Equals(), == and !=.

Point a = new Point(2, 3);
Point b = new Point(2, 3);

Console.WriteLine(a == b); // True, because records use value-based equality

//Deconstruction Records
//You can deconstruct Records same as tuples 

Point p = new Point(3, 3);
(float x, float y) = p; //deconstruction

Console.WriteLine($"x: {x}, y: {y}"); // x: 3, y: 3


/* 'with' EXPRESSION

Creates a copy of a record while changing selected properties.
    All other properties retain their original values.

    Syntax:
newRecord = originalRecord with { Property = newValue };

The original record remains unchanged.
*/

Point p1 = new Point(-2, 5);
Point p2 = p1 with { X = 0 }; // just update X property to 0 and copy Y property.

// replacing many properties at once 
Point p3 = p1 with { X = 0, Y = 0 };

Rectangle rectange = new Rectangle(3, 4);

//-------------------- Record Definition ---------------------------
public record Point(float X, float Y)
{
    //Use of replacing members is defining properties as mutable properties instead of init-only properties. 
    public float X { get; set; } = X;


    // Override ToString() method to provide a custom string representation of the record.
    public override string ToString() => $"({X}, {Y})";
}

// Non-positional record definition
//in this case, you would't get the constructor or ability to deconstruct the record,
//but you can still use the 'with' expression to create modified copies of the record.
public record Point2
{
    public float X { get; init; }
    public float Y { get; init; }
}


public record Rectangle(float Width, float Height)
{
    //If need you can add some extra properties or methods to the record.
    //For example, you can add a property to calculate the area of the rectangle.
    public float Area => Width * Height;
}

//Syntax of record inheritance is similar to class inheritance.
public record Point3(float X, float Y);

public record ColoredPoint(Color Color, float X, float Y) : Point3(X, Y);