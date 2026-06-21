using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Markup;


Console.WriteLine("What is your name?");

// Check if the playerName is not null before using it
string? playerName = Console.ReadLine();
if (playerName != null)
    Console.WriteLine("Name is not null");


ScoreManager _scoreManager;


public class Score
{
    public string Name { get; init; }
    public int Points { get; init; }
    public int Level { get; init; }

    public Score(string name, int points, int level)
    {
        Name = name;
        Points = points;
        Level = level;
    }
}

// 2. The Machine that manages the scores
public class ScoreManager
{
    // The private box stored securely inside the machine
    private Score[] _scores = new Score[10];

    // The public method that hands the box out
    public Score[] GetScores()
    {
        // The exact command that ejects the box to the user
        return _scores;
    }
}