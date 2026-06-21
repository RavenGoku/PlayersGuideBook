AsteroidsGame game = new AsteroidsGame();
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
    public AsteroidsGame()
    {
        _asteroids = new Asteroid[5];
        _asteroids[0] = new Asteroid(100, 200, -4, -2);
        _asteroids[1] = new Asteroid(-50, 100, -1, +3);
        _asteroids[2] = new Asteroid(0, 0, 2, 1);
        _asteroids[3] = new Asteroid(400, -100, -3, -1);
        _asteroids[4] = new Asteroid(200, -300, 0, 3);
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