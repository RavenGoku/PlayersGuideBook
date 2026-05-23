Console.Title = "Classes";

Score a = new Score("R2-D2",12400,15);
Score b = new Score("C3-P0", 8543, 8);
Score first = new();
Score second = new("Ben",160798,20);



if (a.EarnedStar())
    Console.WriteLine($"{a._name} earned a star!");

if (b.EarnedStar())
    Console.WriteLine($"{b._name} earned a star!");

if (second.EarnedStar())
    Console.WriteLine($"{second._name} earned a star!");







//==========================End Main==================================================                          
class Score
{
    public string _name;
    public int _points;
    public int _level;

    //Constructor parameterless
    public Score(): this("Unknown",0,1)
    {}
    //Constructor with parameters
    public Score(string name, int points, int level) 
    {
        _name = name;
        _points = points;
        _level = level;
    }

    public bool EarnedStar() => (_points / _level) > 1000;

}