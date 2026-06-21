using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

/* =================Boss Battle                    The Point                     75 XP =======================
   The first pedestal asks you to create a Point class to store a point in two dimensions. Each point is
   represented by an x-coordinate (x), a side-to-side distance from a special central point called the origin,
   and a y-coordinate (y), an up-and-down distance away from the origin.

Objectives:
   • Define a new Point class with properties for X and Y.
   • Add a constructor to create a point from a specific x- and y-coordinate.
   • Add a parameterless constructor to create a point at the origin (0, 0).
   • In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the
   console window in the format (x, y) to illustrate that the class works.
   • Answer this question: Are your X and Y properties immutable? Why did you choose what you did?
 */


namespace Level24_TheCatacombsOfTheClass
{
    internal class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point() : this(0, 0)
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Teleport(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}