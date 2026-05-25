/*==================  Challenge             The Properties of Arrows                      100 XP ====================
    Vin Fletcher once again has run to catch up to you for help with his arrows. “My apologies, Programmer!
This will be the last time I bother you. My cousin, Flynn Vetcher, is the only other arrow maker in the
area. He doesn’t care for his craft and makes wildly dangerous and overpriced arrows. But people keep
buying them because they think my GetLength() methods are harder to work with than his public
_length fields.I don’t want to give up the protections we just gave these arrows, but I remembered you
saying something about properties. Maybe you could use those to make my arrows easier to work with?”

Objectives:
• Modify your Arrow class to use properties instead of GetX and SetX methods.
• Ensure the whole program can still run, and Vin can keep creating arrows with it.
*/

Console.Title = "The Properties of Arrows";

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
    Arrowhead chosenArrowhead = GetArrowhead();
    Fletching chosenFletching = GetFletching();
    int chosenArrowLength = GetArrowLength();

    return new Arrow(chosenArrowhead, chosenFletching, chosenArrowLength);

    //==================== Local Functions/Methods ============================
    //-------------------------------------------------------------------------
    Arrowhead GetArrowhead()
    {
        Arrowhead arrowhead;
        int choice;
        while (true)
        {
            Console.Write("Choose your Arrowhead: ");
            choice = Convert.ToInt32(Console.ReadLine());
            arrowhead = choice switch
            {
                1 => Arrowhead.Steel,
                2 => Arrowhead.Wood,
                3 => Arrowhead.Obsidian,
                _ => Arrowhead.Unknown,
            };

            if (arrowhead != Arrowhead.Unknown)
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
    Fletching GetFletching()
    {
        Fletching fletching;
        int choice;
        while (true)
        {
            Console.Write("Choose your Fletching: ");
            choice = Convert.ToInt32(Console.ReadLine());
            fletching = choice switch
            {
                1 => Fletching.Plastic,
                2 => Fletching.TurkeyFeathers,
                3 => Fletching.GooseFeathers,
                _ => Fletching.Unknown,
            };

            if (fletching != Fletching.Unknown)
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

//---------------------------------Arrow Class File with essentials-----------------
public enum Arrowhead
{ Unknown, Steel, Wood, Obsidian };

public enum Fletching
{ Unknown, Plastic, TurkeyFeathers, GooseFeathers };

internal class Arrow
{
    public Arrowhead Arrowhead { get; init; }
    public Fletching Fletching { get; init; }
    public int ShaftLength { get; init; }

    //Constructors
    public Arrow() : this(Arrowhead.Steel, Fletching.Plastic, 60)
    { }

    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        if (length <= 100 && length >= 60)
        {
            ShaftLength = length;
        }
        else
        {
            ShaftLength = 60;
        }
    }

    //--------------------------------------------------

    public float GetCost()
    {
        float cost;
        cost = Arrowhead switch
        {
            Arrowhead.Steel => 10f,
            Arrowhead.Wood => 3f,
            Arrowhead.Obsidian => 5f,
            _ => 0f
        };

        cost += Fletching switch
        {
            Fletching.Plastic => 10f,
            Fletching.TurkeyFeathers => 5f,
            Fletching.GooseFeathers => 3f,
            _ => 0f
        };

        cost += (0.05f * ShaftLength);

        return cost;
    }
}