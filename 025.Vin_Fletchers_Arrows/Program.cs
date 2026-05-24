
/*==================  Challenge              Vin Fletcher’s Arrows                      100 XP ====================
    Vin Fletcher is a skilled arrow maker. He asks for your help building a new class to represent arrows and 
    determine how much he should sell them for.“A tiny fragment of my soul goes into each arrow; 
    I care not for the money; I just need to be able to recoup my costs and get food on the table,” he says
    Each arrow has three parts: the arrowhead (steel, wood, or obsidian),the shaft (a length between 60 and
    100 cm long), and the fletching (plastic, turkey feathers, or goose feathers).
    His costs are as follows: For arrowheads, steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold.
    For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold. For the
    shaft, the price depends on the length: 0.05 gold per centimeter.

Objectives:
   • Define a new Arrow class with fields for arrowhead type, fletching type, and length. (Hint:
     arrowhead types and fletching types might be good enumerations.)
   • Allow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.
   • Add a GetCost method that returns its cost as a float based on the numbers above, and use this
   to display the arrow’s cost. 
*/

Console.Title = "VIN FLETCHER'S ARROW";

DisplayMenu();
Arrow first = CreateArrow();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"That arrow costs {first.GetCost()} gold.");
Console.ResetColor();

first = new(Arrow.Arrowhead.Steel, Arrow.Fletching.GooseFeathers, 75);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"That new arrow costs {first.GetCost()} gold.");
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
    
    Arrow.Arrowhead chosenArrowhead =  GetArrowhead();
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

            if(arrowhead != Arrow.Arrowhead.Unknown)
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
            if(choice <= 100 && choice >= 60)
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
    public int _shaftLength;


    //Constructors
    public Arrow(): this(0,0,0) 
    { }
    public Arrow(Arrowhead arrowhead, Fletching fletching, int length )
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        if ( length <= 100 && length >= 60)
        {
            _shaftLength = length;
        }else
        {
            _shaftLength = 60;
        }
    }
    //--------------------------------------------------
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
    
    public enum Arrowhead {Unknown, Steel, Wood, Obsidian };
    public enum Fletching {Unknown, Plastic, TurkeyFeathers, GooseFeathers };
}


