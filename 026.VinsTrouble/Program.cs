
/*==================  Challenge              Vin Trouble                      50 XP ====================
    “Master Programmer!” Vin Fletcher shouts at you as he races to catch up to you. “I have a problem. I
created an arrow for a young man who took it and changed its length to be half as long as I had designed.
It no longer fit in his bow correctly and misfired. It sliced his hand pretty bad. He’ll survive, but is there
any way we can make sure somebody doesn’t change an arrow’s length when they walk away from my
shop? I don’t want to be the cause of such self-inflicted pain.”With your knowledge of information hiding,
you know you can help.

Objectives:
• Modify your Arrow class to have private instead of public fields.
• Add in getter methods for each of the fields that you have. 
*/

Console.Title = "VIN Trouble";

DisplayMenu();
Arrow first = CreateArrow();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"That arrow costs {first.GetCost()} gold.");
Console.ResetColor();





















//================================== Methods and Other ==============================================
void DisplayMenu()
{
    Console.WriteLine(@"
==================================================
            VIN FLETCHER'S ARROWS            
==================================================
""A tiny fragment of my soul goes into each arrow.
 I care not for the money; I just need to recoup 
 my costs and get food on the table.""

------------- CUSTOM ARROW BUILDER ---------------

--- Choose your Arrowhead ---
  1. Steel (10 gold)
  2. Wood (3 gold)
  3. Obsidian (5 gold)

--- Choose your Fletching ---
  1. Plastic (10 gold)
  2. Turkey Feathers (5 gold)
  3. Goose Feathers (3 gold)

--- Choose your Shaft Length ---
  Length must be between 60cm and 100cm.
  (Cost: 0.05 gold per cm)
==================================================");
}
//------------------------------------------------------------------------------------------------
Arrow CreateArrow()
{

    Arrow.Arrowhead chosenArrowhead = GetArrowhead();
    Arrow.Fletching chosenFletching = GetFletching();
    int chosenArrowLength = GetArrowLength();

    return new Arrow(chosenArrowhead, chosenFletching, chosenArrowLength);


    //==================== Local Functions/Methods ============================
    //-------------------------------------------------------------------------
    Arrow.Arrowhead GetArrowhead()
    {
        Arrow.Arrowhead arrowhead;
        int choice;
        while (true)
        {
            Console.Write("Choose your Arrowhead: ");
            choice = Convert.ToInt32(Console.ReadLine());
            arrowhead = choice switch
            {
                1 => Arrow.Arrowhead.Steel,
                2 => Arrow.Arrowhead.Wood,
                3 => Arrow.Arrowhead.Obsidian,
                _ => Arrow.Arrowhead.Unknown,

            };

            if (arrowhead != Arrow.Arrowhead.Unknown)
            {
                Console.Clear();
                DisplayMenu();
                break;
            }
            else
            {
                Console.WriteLine("Wrong choice, try again!\r");
            }

        }

        return arrowhead;
    }
    //-------------------------------------------------------------------------
    Arrow.Fletching GetFletching()
    {
        Arrow.Fletching fletching;
        int choice;
        while (true)
        {
            Console.Write("Choose your Fletching: ");
            choice = Convert.ToInt32(Console.ReadLine());
            fletching = choice switch
            {
                1 => Arrow.Fletching.Plastic,
                2 => Arrow.Fletching.TurkeyFeathers,
                3 => Arrow.Fletching.GooseFeathers,
                _ => Arrow.Fletching.Unknown,

            };

            if (fletching != Arrow.Fletching.Unknown)
            {
                Console.Clear();
                DisplayMenu();
                break;
            }
            else
            {
                Console.WriteLine("Wrong choice, try again!\r");
            }

        }

        return fletching;
    }
    //-------------------------------------------------------------------------
    int GetArrowLength()
    {
        int arrowLength;
        int choice;
        while (true)
        {
            Console.Write("Choose your length: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice <= 100 && choice >= 60)
            {
                arrowLength = choice;
                Console.Clear();
                DisplayMenu();
                break;
            }
            else
            {
                Console.WriteLine("Out of range, try again!\r");
            }

        }
        return arrowLength;

    }

}
//------------------------------------------------------------------------------------------------
class Arrow
{
    Arrowhead _arrowhead;
    Fletching _fletching;
    private int _shaftLength;


    //Constructors
    public Arrow() : this(0, 0, 0)
    { }
    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        if (length <= 100 && length >= 60)
        {
            _shaftLength = length;
        }
        else
        {
            _shaftLength = 60;
        }
    }
    //--------------------------------------------------
    public Arrowhead GetArrowhead() => _arrowhead;
    public Fletching GetFletching() => _fletching;
    public int GetLength() => _shaftLength;
    public float GetCost()
    {
        float cost;
        cost = _arrowhead switch
        {
            Arrowhead.Steel => 10f,
            Arrowhead.Wood => 3f,
            Arrowhead.Obsidian => 5f,
            _ => 0f
        };

        cost += _fletching switch
        {
            Fletching.Plastic => 10f,
            Fletching.TurkeyFeathers => 5f,
            Fletching.GooseFeathers => 3f,
            _ => 0f
        };

        cost += (0.05f * _shaftLength);



        return cost;
    }


    public enum Arrowhead { Unknown, Steel, Wood, Obsidian };
    public enum Fletching { Unknown, Plastic, TurkeyFeathers, GooseFeathers };
}


