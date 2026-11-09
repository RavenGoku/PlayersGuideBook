Point p1 = new Point(2, 4);
Console.WriteLine($"Point coordinates: ({p1.X}, {p1.Y})");

PairOfInts pair;
pair.A = 2;
Console.WriteLine($"Pair of ints: A = {pair.A}");


PairOfPairs Pairs = new PairOfPairs();

Pairs.Display();

Pairs._one.A = 2;

Pairs.Display();


object thing = 3;
int number = (int)thing;


Console.WriteLine(typeof(int).BaseType);
Console.WriteLine(typeof(ValueType).BaseType);
Console.WriteLine(typeof(object).BaseType);


// ----------------------- Class definition----------------
public class CircleClass
{
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }

    public CircleClass(double x, double y, double r)
    {
        X = x;
        Y = y;
        Radius = r;
    }
}

public class PairOfPairs
{
    public PairOfInts _one;
    public PairOfInts _two;


    public void Display()
    {
        Console.WriteLine($"Pair of pairs: One = ({_one.A}, {_one.B}), and Two = ({_two.A}, {_two.B})");
    }
}


//---------------- Structs Definition -----------------
//
// A struct in C# is a value type that implicitly derives from
// System.ValueType and groups related data and behaviour.
//
// Structs have value semantics: assignment and passing by value
// copy their contents rather than sharing the same instance.
//
// Structs can implement interfaces but cannot inherit from
// other classes or structs.
//
// Structs always have a default, zero-initialized value.
// Modern C# also allows explicit parameterless constructors.
//
// Prefer structs for small, data-focused, preferably immutable
// types that represent independent values.
//
// Avoid large structs when frequent copying could introduce
// unnecessary performance overhead.

public struct CircleStruct
{
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }

    public CircleStruct(double x, double y, double r)
    {
        X = x;
        Y = y;
        Radius = r;
    }
}


public struct Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

public struct PairOfInts
{
    public int A;
    public int B;
}

public readonly struct DamageRange
{
    public int minDamage { get; }
    public int maxDamage { get; }
}