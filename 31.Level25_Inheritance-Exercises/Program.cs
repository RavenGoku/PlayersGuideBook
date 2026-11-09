using _31.Level25_Inheritance_Exercises;

  Asteroid asteroid = new Asteroid(2,3,4,6);
  GameObject gameObject = new Asteroid();

Console.WriteLine($"Rotation Angle = {asteroid.RotationAngle}");

//
if (gameObject.GetType() == typeof(Asteroid))
{
    Console.WriteLine("This is an Asteroid");
}else
{
    Console.WriteLine("WARNING!! This is not an Asteroid!");
}

// Create a variable of type Asteroid and assign it the value of gameObject using the 'as' operator
Asteroid? asteroid2 = gameObject as Asteroid;


//Check type and assign to a variable in one step using pattern matching
if (gameObject is Asteroid asteroid3)
{
    //you can use asteroid3 here
}

//If you don't need to use the variable, you can skip the name and just check the type
if (gameObject is Asteroid)
{
    //you can use gameObject here
}





