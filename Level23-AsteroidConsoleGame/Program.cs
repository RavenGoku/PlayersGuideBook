AsteroidsGame game = new AsteroidsGame(new Asteroid[5]);
game.Run();


// This is a simple console application that simulates a basic asteroid game.
public class Asteroid
{
    // Properties
    public float PositionX { get; private set; }
    public float PositionY { get; private set; }
    public float VelocityX { get; private set; }
    public float VelocityY { get; private set; }

    // Constructor, that initializes the asteroid's position and velocity
    public Asteroid(float positionX, float positionY,
        float velocityX, float velocityY)
    {
        PositionX = positionX;
        PositionY = positionY;
        VelocityX = velocityX;
        VelocityY = velocityY;
    }

    // Method to update the asteroid's position based on its velocity
    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}

public class AsteroidsGame
{
    // Array to hold the asteroids in the game
    private Asteroid[] _asteroids;

    // Constructor, that initializes the asteroids in the game
    public AsteroidsGame(Asteroid[] startingAsteroids)
    {
        _asteroids = startingAsteroids;
    }

    public void Run()
    {
        //loop to update the asteroids' positions indefinitely
        while (true)
        {
            // Update the position of each asteroid, while the game is running
            foreach (Asteroid asteroid in _asteroids)
            {
                for (int i = 0; i <= 1000_000_000; i++)
                {
                    if (i == 1000_000_000)
                        Console.WriteLine(
                            $"asteroid position[{asteroid.PositionX},{asteroid.PositionY}], and velocity[{asteroid.VelocityX},{asteroid.VelocityY}]");
                }

                asteroid.Update();
            }
        }
    }
}