using Level24_TheCatacombsOfTheClass;

// Point class is defined in the Level24_TheCatacombsOfTheClass namespace, so we need to include that namespace in our Program.cs file.
Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"Point 1 ({point1.X},{point1.Y}); Point 2 ({point2.X},{point2.Y})");


//Color class is defined in the Level24_TheCatacombsOfTheClass namespace
Color newColor = new Color(158, 245, 65);
Color orange = Color.Orange;

Console.WriteLine(newColor.BlueChannel);

